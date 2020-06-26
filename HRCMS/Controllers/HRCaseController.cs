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
using System.Net;
using System.Reflection.Metadata;
using System.Text.Encodings.Web;
using System.Web;
using System.IO;
using System.Text;
using System.Net.Mime;
using HRCMS.Utility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Localization;

namespace HRCMS.Controllers
{
    [Authorize]
    public class HRCaseController : ExtendedBaseController
    {
        private readonly IHRCaseRepository _repository;
        private readonly ICaseTypeRepository _caseTypeRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnnotationRepository _annotationRepository;
        private readonly IUserRepository _userRepository;
        private readonly LinkGenerator _linkGenerator;
        private readonly Dynamics _appSettings;
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly long _fileSizeLimit;
        private readonly IStringLocalizer<HRCaseController> _localizer;

        public HRCaseController(IHRCaseRepository repository, ICaseTypeRepository caseTypeRepository, IUserRepository userRepository, IQuestionRepository questionRepository, IAnnotationRepository annotationRepository
            , IMapper mapper
            , LinkGenerator linkGenerator,  IOptions<Dynamics> settings, ModelAccessor modelAccessor, IConfiguration config, IStringLocalizer<HRCaseController> localizer) : base(modelAccessor)
        {
            _repository = repository;
            _caseTypeRepository = caseTypeRepository;
            _userRepository = userRepository;
            _questionRepository = questionRepository;
            _annotationRepository = annotationRepository;
            _linkGenerator = linkGenerator;
            _appSettings = settings.Value;
            _mapper = mapper;

            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");
            _localizer = localizer;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            try            
            {
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["Home"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["View My Cases"] });
                
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();

                var pri = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value;

                //var statuses = Request.Cookies["caseList"];

                //if(statuses == null)
                //{
                //    statuses = "315840000|315840001|315840002|315840003"; //Default list to Open cases
                //}
                //else
                //{
                //    statuses = HttpUtility.UrlDecode(statuses);
                //}           

                var openStatus = "315840000|315840001|315840002|315840003";
                var closedStatus = "315840004|315840005|315840006";

                var openCases = await _repository.GetAllCasesAsync(pri, openStatus, WebTemplateModel.TwoLetterCultureLanguage);
                var closedCases = await _repository.GetAllCasesAsync(pri, closedStatus, WebTemplateModel.TwoLetterCultureLanguage);
                var questions = await _questionRepository.GetAllUnAnsweredQuestionsAsync(pri);

                //Get case status because 'Received by HR' here eq 'New Cases' in Dynamics
                foreach (var hrcase in openCases)
                {
                    hrcase.CaseStatusText = caseStatuses.FirstOrDefault(t => t.Value == hrcase.CaseStatusId)?.Text;
                }
                foreach (var hrcase in closedCases)
                {
                    hrcase.CaseStatusText = caseStatuses.FirstOrDefault(t => t.Value == hrcase.CaseStatusId)?.Text;
                }

                var listModel = new ListViewModel() { OpenCases = openCases, ClosedCases = closedCases, Questions = questions };

                return View(listModel);
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
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../List", Title = _localizer["Home"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../List", Title = _localizer["Cases"] });


                var hrCaseModel = await _repository.GetCaseAsync(id, WebTemplateModel.TwoLetterCultureLanguage);

                //var hrCaseModel = _mapper.Map<HRCaseModel>(result);

                if(Int32.Parse(hrCaseModel.PRI)!= Int32.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid)?.Value))
                {
                    ModelState.AddModelError(string.Empty, "Unauthorized");
                    return RedirectToAction("List");
                }

                //Get case status because 'Received by HR' here eq 'New Cases' in Dynamics
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync();
                hrCaseModel.CaseStatusText = caseStatuses.FirstOrDefault(t => t.Value == hrCaseModel.CaseStatusId)?.Text;

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
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["Home"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["View My Cases"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "", Title = _localizer["Add a new case"] });

                var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync( WebTemplateModel.TwoLetterCultureLanguage);
                var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync( WebTemplateModel.TwoLetterCultureLanguage);
                var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync( );

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
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["Home"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "../hrcase/List", Title = _localizer["View My Cases"] });
                WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "", Title = _localizer["Update a case"] });

                var result = await _repository.GetCaseAsync(id, WebTemplateModel.TwoLetterCultureLanguage);
                var hrCaseModel = _mapper.Map<HRCaseModel>(result);

                hrCaseModel.CaseTypes = await _caseTypeRepository.GetAllCaseTypesAsync( WebTemplateModel.TwoLetterCultureLanguage);
                //Set Case subtype according to case type
                if (!string.IsNullOrEmpty(hrCaseModel.CaseType.TypeId))
                {
                    hrCaseModel.CaseSubTypes = await _caseTypeRepository.GetCaseSubTypesAsync(hrCaseModel.CaseType.TypeId, WebTemplateModel.TwoLetterCultureLanguage);
                }
                else
                {
                    hrCaseModel.CaseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync( WebTemplateModel.TwoLetterCultureLanguage); 
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
            hrCaseModel.PRI = hrCaseModel.PRI.Replace("-", "");

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
                    return RedirectToAction("Update", new { id = caseId });
                }
                else
                {
                    ModelState.AddModelError("Error", "Error: Not able to connect to the database.");
                }
            }
            var caseTypes = await _caseTypeRepository.GetAllCaseTypesAsync( WebTemplateModel.TwoLetterCultureLanguage);
            var caseSubTypes = await _caseTypeRepository.GetAllCaseSubTypesAsync( WebTemplateModel.TwoLetterCultureLanguage);
            var caseStatuses = await _caseTypeRepository.GetAllCaseStatusesAsync( );
            hrCaseModel.CaseTypes = caseTypes;
            hrCaseModel.CaseSubTypes = caseSubTypes;
            hrCaseModel.CaseStatuses = caseStatuses;
            return View(hrCaseModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(HRCaseModel hrCaseModel)
        {
            hrCaseModel.CaseStatusId = "315840001";
            hrCaseModel.PRI = hrCaseModel.PRI.Replace("-", "");
            if (ModelState.IsValid)
            {
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
                if (caseId == null)
                {
                    ModelState.AddModelError("Error", "Error: Not able to submit.");
                }
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
                IEnumerable<SelectListItem> caseSubTypes = await _caseTypeRepository.GetCaseSubTypesAsync(caseTypeId, WebTemplateModel.TwoLetterCultureLanguage);
                return Json(caseSubTypes);
            }
            return null;
        }      

        [HttpGet]
        public async Task<IActionResult> DownloadAttachment(string attachmentId)
        {
            var annotation = await _annotationRepository.GetAnnotationAsync(attachmentId);
            byte[] fileBytes = Convert.FromBase64String(annotation.DocumentBody);
            string fileName = annotation.FileName;

            return File(fileBytes, MediaTypeNames.Application.Octet, WebUtility.HtmlEncode(fileName));
        }

        [HttpPost]
        public async Task<IActionResult> UploadAttachment(AnnotationModel newAttachment)
        {
            if (ModelState.IsValid)
            {
                var attachment = _mapper.Map<Annotation>(newAttachment);
                attachment._objectid_value = newAttachment.CaseId;
                attachment.filename = newAttachment.File.FileName;
                attachment.mimetype = newAttachment.File.ContentType;
                attachment.documentbody = await newAttachment.File.ReadAsBase64StringAsync(ModelState, _fileSizeLimit);

                await _annotationRepository.UploadAttatchmentAsync(attachment);
                return RedirectToAction("Details", "HRCase", new { id = newAttachment.CaseId }, "tbAttachments");
            }
            else
            {

            }
            return RedirectToAction("Details", "HRCase", new { id = newAttachment.CaseId }, "tbAttachments");
        }
     
    }
}
