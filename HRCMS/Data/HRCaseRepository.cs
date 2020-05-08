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

        public async Task<List<HRCase>> GetAllCasesAsync(string pri)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_hrcases";
                var filter = $"$filter=hr_pri%20eq%20{pri}";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}?{filter}");

                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {

                        var hrCases = JsonConvert.DeserializeObject<List<HRCase>>(JObject.Parse(results)["value"].ToString(), new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        return hrCases;
                    }
                }
            }
            return null;
        }
      
        public async Task<HRCase> GetCaseAsync(string caseId)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_hrcases";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({caseId})");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (result != null)
                    {
                        var hrCase = JsonConvert.DeserializeObject<HRCase>(result, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        return hrCase;
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
                    jCase.hr_datereceived = DateTime.Now;
                    jCase["hr_CaseType@odata.bind"] = $"/hr_casetypes({hrCase._hr_casetype_value})";
                    jCase["hr_CaseSubType@odata.bind"] = $"/hr_casesubtypes({hrCase._hr_casesubtype_value})";

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
                    if (hrCase._hr_casetype_value != null) jCase["hr_CaseType@odata.bind"] = $"/hr_casetypes({hrCase._hr_casetype_value})";
                    if (hrCase._hr_casesubtype_value != null) jCase["hr_CaseSubType@odata.bind"] = $"/hr_casesubtypes({hrCase._hr_casesubtype_value})";

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
