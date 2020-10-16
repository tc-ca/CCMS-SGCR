using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HRCMS.ViewModels;
using AutoMapper;
using Microsoft.Extensions.Options;
using System.Text;
using System.Net.Http;
using System.Linq;
using System.Text.Encodings.Web;
using System.Web;

namespace HRCMS.Data
{
    public class HRCaseRepository : IHRCaseRepository
    {
        private readonly ILogger<HRCaseRepository> _logger;
        private readonly Dynamics _appSettings;
        private readonly IMapper _mapper;

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public HRCaseRepository(IMapper mapper, IOptions<Dynamics> settings)
        {
            _mapper = mapper;
            _appSettings = settings.Value;
        }

        public async Task<List<HRCaseModel>> GetAllCasesAsync(string pri, string statuses, string twoLetterCultureLanguage)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_hrcases";
                var statusList = statuses.Split("|");
                var orderby = $"$orderby=createdon%20desc";
                var statusFilter = "[%27" + string.Join("%27,%27", statusList) + "%27]";
                var select = $"$select=hr_lastname,hr_name,hr_casestatus,hr_firstname,hr_hrcaseid,createdon,hr_datereceived&$expand=hr_CaseType($select=hr_name,hr_nameen,hr_namefr),hr_CaseSubType($select=hr_name,hr_nameen,hr_namefr)";
                var filter = $"$filter=hr_pri%20eq%20%27{pri}%27%20and%20Microsoft.Dynamics.CRM.In(PropertyName=%27hr_casestatus%27,PropertyValues={statusFilter})";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}?{select}&{filter}&{orderby}");

                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        var hrCases = JsonConvert.DeserializeObject<List<HRCase>>(JObject.Parse(results)["value"].ToString(), new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        if (twoLetterCultureLanguage == "en")
                        {
                            hrCases.Select(c => { if (c.hr_CaseType != null) { c.hr_CaseType.hr_name = c.hr_CaseType.hr_nameen; } return c; }).ToList();
                            hrCases.Select(c => { if (c.hr_CaseSubType != null) { c.hr_CaseSubType.hr_name = c.hr_CaseSubType.hr_nameen; } return c; }).ToList();
                        }
                        else
                        {
                            hrCases.Select(c => { if (c.hr_CaseType != null) { c.hr_CaseType.hr_name = c.hr_CaseType.hr_namefr; } return c; }).ToList();
                            hrCases.Select(c => { if (c.hr_CaseSubType != null) { c.hr_CaseSubType.hr_name = c.hr_CaseSubType.hr_namefr; } return c; }).ToList();

                        }
                        var hrCaseModels = _mapper.Map<List<HRCaseModel>>(hrCases);
                        return hrCaseModels;
                    }
                }
                else
                {
                    //ModelState.AddModelError(string.Empty, "Unable to authenticate. Please check your user name");
                }
            }
            return null;
        }
        
        public async Task<HRCaseModel> GetCaseAsync(string caseId, string twoLetterCultureLanguage)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_hrcases";
                var appUserid = _appSettings.AppUserId;
                var select = $"$expand=hr_CaseType($select=hr_name,hr_nameen,hr_namefr),hr_CaseSubType($select=hr_name,hr_nameen,hr_namefr)," +
                    $"hr_HRCase_hr_HRCase_hr_QuestionandAnswers($select=hr_questionandanswersid,hr_question,hr_answer,hr_read,hr_askedon,hr_answeredon,hr_questionsequencenumber)," +
                    $"hr_hrcase_Annotations($select=_objectid_value,filename,subject,notetext,createdon,mimetype;$filter=isdocument%20eq%20true%20and%20_createdby_value%20eq%20{appUserid})";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({caseId})?{select}");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (result != null)
                    {
                        var hrCase = JsonConvert.DeserializeObject<HRCase>(result, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        if (twoLetterCultureLanguage == "en")
                        {
                            if (hrCase.hr_CaseType != null) { hrCase.hr_CaseType.hr_name = hrCase.hr_CaseType.hr_nameen; }
                            if (hrCase.hr_CaseSubType != null) { hrCase.hr_CaseSubType.hr_name = hrCase.hr_CaseSubType.hr_nameen; }
                        }
                        else
                        {
                            if (hrCase.hr_CaseType != null) { hrCase.hr_CaseType.hr_name = hrCase.hr_CaseType.hr_namefr; }
                            if (hrCase.hr_CaseSubType != null) { hrCase.hr_CaseSubType.hr_name = hrCase.hr_CaseSubType.hr_namefr; }
                        }
                        var hrCaseModel = _mapper.Map<HRCaseModel>(hrCase);

                        hrCaseModel.UnAnsweredQuestions = hrCaseModel.Questions.Where(q => string.IsNullOrEmpty(q.DateAnswered)).OrderBy(q => q.DateAsked).ToList();
                        hrCaseModel.AnsweredQuestions = hrCaseModel.Questions.Where(q => !string.IsNullOrEmpty(q.DateAnswered)).OrderBy(q => q.DateAsked).ToList();

                        hrCaseModel.Attachments.Sort((x, y) => string.Compare(y.DateCreated, x.DateCreated));
                        return hrCaseModel;
                    }
                }
            }
            return null;
        }
              

        public async Task<string> CreateHRCaseAsync(HRCase hrCase)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    var entityName = "hr_hrcases";
                    dynamic jCase = new JObject();
                    jCase.hr_lastname = hrCase.hr_lastname;
                    jCase.hr_firstname = hrCase.hr_firstname;
                    jCase.hr_pri = hrCase.hr_pri;
                    jCase.hr_email = hrCase.hr_email;
                    jCase.hr_casestatus = hrCase.hr_casestatus; 
                    jCase.hr_description = hrCase.hr_description;
                    //jCase.hr_datereceived = DateTime.Now;
                    if (hrCase.hr_CaseType.hr_casetypeid != null)
                    {
                        jCase["hr_CaseType@odata.bind"] = $"/hr_casetypes({hrCase.hr_CaseType.hr_casetypeid})";
                    }
                    if (hrCase.hr_CaseSubType.hr_casesubtypeid != null)
                    {
                        jCase["hr_CaseSubType@odata.bind"] = $"/hr_casesubtypes({hrCase.hr_CaseSubType.hr_casesubtypeid})";
                    }

                    var caseContent = new StringContent(jCase.ToString(), Encoding.UTF8, "application/json");
                    
                    HttpRequestMessage createrequest1 = new HttpRequestMessage(HttpMethod.Post, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}");
                    createrequest1.Content = caseContent;

                    var response = await client.SendAsync(createrequest1, HttpCompletionOption.ResponseHeadersRead);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result != null)
                        {
                            var entityId = response.Headers.GetValues("OData-EntityId").FirstOrDefault(); 
                            entityId= entityId.Substring(entityId.IndexOf("(") + 1, 36);
                            return entityId;
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                //var errorMsg = Message.HttpRequestNotSuccessfull(ex.Message, httpMethod, messageUri, body);
                //this.log.Error(Message.Error($"{nameof(RestApiClient)}.{nameof(this.SendMessageAsync)}", errorMsg));

                //throw ex;
            }
            return null;
        }

        public async Task<string> UpdateHRCaseAsync(HRCase hrCase)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    //client.DefaultRequestHeaders.Add("Prefer", "return=representation");
                    var entityName = "hr_hrcases";
                    dynamic jCase = new JObject();

                    //if(hrCase.hr_lastname!=null) jCase.hr_lastname = hrCase.hr_lastname;Should not be updated
                    //if (hrCase.hr_lastname != null) jCase.hr_firstname = hrCase.hr_firstname;Should not be updated
                    //if (hrCase.hr_lastname != null) jCase.hr_pri = hrCase.hr_pri;Should not be updated
                    //if (hrCase.hr_lastname != null) jCase.hr_datereceived = DateTime.Now; Should not be updated

                    if (hrCase.hr_email != null) jCase.hr_email = hrCase.hr_email;
                    if (hrCase.hr_casestatus != null) jCase.hr_casestatus = hrCase.hr_casestatus;
                    if (hrCase.hr_description != null) jCase.hr_description = hrCase.hr_description;
                    if (hrCase.hr_CaseType != null) jCase["hr_CaseType@odata.bind"] = $"/hr_casetypes({hrCase.hr_CaseType.hr_casetypeid})";
                    if (hrCase.hr_CaseSubType != null) jCase["hr_CaseSubType@odata.bind"] = $"/hr_casesubtypes({hrCase.hr_CaseSubType.hr_casesubtypeid})";

                    var caseContent = new StringContent(jCase.ToString(), Encoding.UTF8, "application/json");

                    HttpRequestMessage updateRequest = new HttpRequestMessage(HttpMethod.Patch, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({hrCase.hr_hrcaseid})");
                    updateRequest.Content = caseContent;

                    var response = await client.SendAsync(updateRequest, HttpCompletionOption.ResponseHeadersRead);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (result != null)
                        {
                            var entityId = response.Headers.GetValues("OData-EntityId").FirstOrDefault();
                            entityId = entityId.Substring(entityId.IndexOf("(") + 1, 36);
                            return entityId;
                        }
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                //var errorMsg = Message.HttpRequestNotSuccessfull(ex.Message, httpMethod, messageUri, body);
                //this.log.Error(Message.Error($"{nameof(RestApiClient)}.{nameof(this.SendMessageAsync)}", errorMsg));

                throw ex;
            }
            return null;
        }

        public async Task<bool> DeleteHRCaseAsync(string caseId)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    var entityName = "hr_hrcases";

                    HttpRequestMessage deleteRequest = new HttpRequestMessage(HttpMethod.Delete, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({caseId})");

                    var response = await client.SendAsync(deleteRequest, HttpCompletionOption.ResponseHeadersRead);

                    if (response.IsSuccessStatusCode)
                    {                       
                        return true;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                //var errorMsg = Message.HttpRequestNotSuccessfull(ex.Message, httpMethod, messageUri, body);
                //this.log.Error(Message.Error($"{nameof(RestApiClient)}.{nameof(this.SendMessageAsync)}", errorMsg));

                throw ex;
            }
            return false;
        }
    }
}
