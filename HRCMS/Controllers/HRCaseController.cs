using AutoMapper;
using GoC.WebTemplate.Components.Core.Services;
using HRCMS.Data;
using HRCMS.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GoC.WebTemplate.Components.Entities;
using GoC.WebTemplate.CoreMVC.Controllers;

namespace HRCMS.Controllers
{
    [Authorize]
    public class HRCaseController : ExtendedBaseController
    {
        private readonly IHRCaseRepository _repository;
        private readonly ICaseTypeRepository _caseTypeRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IUserRepository _userRepository;
        private readonly LinkGenerator _linkGenerator;
        private readonly Dynamics _appSettings;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HRCaseController(IHRCaseRepository repository, ICaseTypeRepository caseTypeRepository, IUserRepository userRepository, IQuestionRepository questionRepository
            , IMapper mapper
            , LinkGenerator linkGenerator,  IOptions<Dynamics> settings, ModelAccessor modelAccessor) : base(modelAccessor)
        {
            _repository = repository;
            _caseTypeRepository = caseTypeRepository;
            _userRepository = userRepository;
            _questionRepository = questionRepository;
            _linkGenerator = linkGenerator;
            _appSettings = settings.Value;
            _mapper = mapper;
            WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "/Home/Logout", Title = "Home" });
            WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "/hrcase/List", Title = "Cases" });

        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            try            
            {
                var pri = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value;                

                var results = await _repository.GetAllCasesAsync(pri);

                var hrCases = _mapper.Map<List<HRCaseModel>>(results).OrderByDescending(m => m.CaseNumber).ToList<HRCaseModel>();

                var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync();
                var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync();
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();
                foreach (var hrcase in hrCases)
                {
                    hrcase.CaseTypeText = caseTypes.FirstOrDefault(t => t.Value == hrcase.CaseTypeId)?.Text;
                    hrcase.CaseSubTypeText = caseSubTypes.FirstOrDefault(t => t.Value == hrcase.CaseSubTypeId)?.Text; ;
                    hrcase.CaseStatusText = caseStatuses.FirstOrDefault(t => t.Value == hrcase.CaseStatusId)?.Text; ;
                }

                return View(hrCases);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                var result = await _repository.GetCaseAsync(id);

                var hrCaseModel = _mapper.Map<HRCaseModel>(result);

                if(Int32.Parse(hrCaseModel.PRI)!= Int32.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value))
                {
                    ModelState.AddModelError(string.Empty, "Unauthorized");
                    return RedirectToAction("List");
                }

                var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync();
                var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync();
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();
                var questions = await _questionRepository.GetAllQuestionsAsync(hrCaseModel.CaseId);
                hrCaseModel.CaseTypeText = caseTypes.FirstOrDefault(t => t.Value == hrCaseModel.CaseTypeId)?.Text;
                hrCaseModel.CaseSubTypeText = caseSubTypes.FirstOrDefault(t => t.Value == hrCaseModel.CaseSubTypeId)?.Text; 
                hrCaseModel.CaseStatusText = caseStatuses.FirstOrDefault(t => t.Value == hrCaseModel.CaseStatusId)?.Text;
                if (questions != null)
                {
                    hrCaseModel.Questions = _mapper.Map<List<QuestionModel>>(questions);
                }

                return View(hrCaseModel);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync();
                var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync();
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();

                var caseModel = new HRCaseModel
                {
                    CaseStatusId = "315840001", //New Case
                    CaseTypes = caseTypes,
                    CaseSubTypes = caseSubTypes,
                    CaseStatuses = caseStatuses,
                    FirstName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value,
                    LastName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value,
                    Email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                    PRI = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value
                };
                return View(caseModel);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            try
            {
                var result = await _repository.GetCaseAsync(id);
                var hrCaseModel = _mapper.Map<HRCaseModel>(result);

                hrCaseModel.CaseTypes = await _caseTypeRepository.GetAllCaseTypesAsync();
                if (!string.IsNullOrEmpty(hrCaseModel.CaseTypeId))
                {
                    hrCaseModel.CaseSubTypes = await _caseTypeRepository.GetCaseSubTypesAsync(hrCaseModel.CaseTypeId);
                }
                else
                {
                    hrCaseModel.CaseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync(); ;
                }
                hrCaseModel.CaseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync(); ;

                if (Int32.Parse(hrCaseModel.PRI) != Int32.Parse( User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value))
                {
                    ModelState.AddModelError(string.Empty, "Unauthorized");
                    return RedirectToAction("List");
                }

                

                return View("Create", hrCaseModel);
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(HRCaseModel hrCaseModel)
        {
            if (ModelState.IsValid)
            {
                //Call the API to save case
                hrCaseModel.CaseStatusId = "315840002";
                var hrCase = _mapper.Map<HRCase>(hrCaseModel);
                string caseId;
                if (string.IsNullOrEmpty(hrCaseModel.CaseId))
                {                    
                    caseId = await _repository.CreateHRCaseAsync(hrCase);
                }
                else
                {
                    caseId = await _repository.UpdateHRCaseAsync(hrCase);
                }
                if (caseId != null)
                {
                    return RedirectToAction("Details", "HRCase", new { id = caseId });
                }
            }
            var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync();
            var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync();
            var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();
            hrCaseModel.CaseTypes = caseTypes;
            hrCaseModel.CaseSubTypes = caseSubTypes;
            hrCaseModel.CaseStatuses = caseStatuses;

            ModelState.AddModelError(string.Empty, "Not a valid model");
            return View(hrCaseModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(HRCaseModel hrCaseModel)
        {
            var hrCase = new HRCase { hr_hrcaseid = hrCaseModel.CaseId, hr_casestatus = "315840001" }; //Withdrown by client
            var result = await _repository.UpdateHRCaseAsync(hrCase);
            if (result == null)
            {
                ModelState.AddModelError(string.Empty, "Error: Not able to update.");
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Withdraw(HRCaseModel hrCaseModel)
        {
            //Call the API to save case
            var hrCase = new HRCase { hr_hrcaseid = hrCaseModel.CaseId, hr_casestatus = "315840006" }; //Withdrown by client

            var result = await _repository.UpdateHRCaseAsync(hrCase);
            if (result == null)
            {
                ModelState.AddModelError(string.Empty, "Error: Not able to withdraw.");
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(HRCaseModel hrCaseModel)
        {

            //Call the API to save case
            var deleted = await _repository.DeleteHRCaseAsync(hrCaseModel.CaseId);
            if (!deleted)
            {
                ModelState.AddModelError(string.Empty, "Error: Unable to delete.");
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAnswers(HRCaseModel hrCaseModel)
        {

            //Call the API to save case
            var questions = hrCaseModel.Questions;
            if (questions != null)
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    if (!string.IsNullOrEmpty(questions[i].AnswerText))
                    {
                        var ques = _mapper.Map<Question>(questions[i]);
                        await _questionRepository.UpdateAnswerAsync(ques);
                    }
                }
            }
            //return View(hrCaseModel);

            return RedirectToAction("List");
        }

        /// <summary>
        /// Get sub type based on case type selected
        /// </summary>
        /// <param name="caseTypeId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<JsonResult> GetCaseSubTypes(string caseTypeId)
        {
            if (!string.IsNullOrWhiteSpace(caseTypeId))
            {
                IEnumerable<SelectListItem> caseSubTypes = await _caseTypeRepository.GetCaseSubTypesAsync(caseTypeId);
                return Json(caseSubTypes);
            }
            return null;
        }

    }
}
