using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class CaseTypeRepository : ICaseTypeRepository
    {
        private readonly Dynamics _appSettings;
        public CaseTypeRepository(IOptions<Dynamics> settings)
        {
            _appSettings = settings.Value;
        }
        //[OutputCache(Duration = 60)]
        public async Task<IEnumerable<SelectListItem>> GetAllCaseTypesAsync(string twoLetterCultureLanguage)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_casetypes";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}");
                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        List<CaseType> caseTypeList = JsonConvert.DeserializeObject<List<CaseType>>(JObject.Parse(results)["value"].ToString(), new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        if (twoLetterCultureLanguage == "en")
                        {
                            return caseTypeList.Select(n => new SelectListItem { Value = n.hr_casetypeid, Text = n.hr_nameen }).OrderBy(m => m.Text);
                        }
                        else
                        {
                            return caseTypeList.Select(n => new SelectListItem { Value = n.hr_casetypeid, Text = n.hr_namefr }).OrderBy(m => m.Text);
                        }
                    }
                }
            }
            return null;
        }
        //[OutputCache(Duration = 60)]
        public async Task<IEnumerable<SelectListItem>> GetAllCaseSubTypesAsync(string twoLetterCultureLanguage)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_casesubtypes";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}");

                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        var subTypeList = JsonConvert.DeserializeObject<List<CaseSubType>>(JObject.Parse(results)["value"].ToString(), new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        if (twoLetterCultureLanguage == "en")
                        {
                            return subTypeList.Select(n => new SelectListItem { Value = n.hr_casesubtypeid, Text = n.hr_nameen }).OrderBy(m => m.Text);
                        }
                        else
                        {
                            return subTypeList.Select(n => new SelectListItem { Value = n.hr_casesubtypeid, Text = n.hr_namefr }).OrderBy(m => m.Text);
                        }
                    }
                }
            }
            return null;
        }
               
        public async Task<IEnumerable<SelectListItem>> GetCaseSubTypesAsync(string caseTypeId, string twoLetterCultureLanguage)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_casetypes";
                var query = $"$top=50&$expand=hr_CaseType_hr_CaseSubType_hr_CaseSubType($select=hr_name,hr_casesubtypeid)&$filter=hr_casetypeid%20eq%20{caseTypeId}";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}?{query}");
                
                //var response = await client.GetAsync($"https://hrcms-dev-tcd365.crm3.dynamics.com/api/data/v9.1/hr_casetypes?$top=50&$expand=hr_CaseType_hr_CaseSubType_hr_CaseSubType($select=hr_name,hr_casesubtypeid)&$filter=hr_casetypeid%20eq%20{caseTypeId}");
                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        List<CaseSubType> caseSubTypeList = JsonConvert.DeserializeObject<List<CaseSubType>>(JObject.Parse(results)["value"][0]["hr_CaseType_hr_CaseSubType_hr_CaseSubType"].ToString());
                        if (twoLetterCultureLanguage == "en")
                        {
                            return caseSubTypeList.Select(n => new SelectListItem { Value = n.hr_casesubtypeid, Text = n.hr_nameen }).OrderBy(m => m.Text);
                        }
                        else
                        {
                            return caseSubTypeList.Select(n => new SelectListItem { Value = n.hr_casesubtypeid, Text = n.hr_namefr }).OrderBy(m => m.Text);
                        }

                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<SelectListItem>> GetAllCaseStatusesAsync()
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var optionSetName = "GlobalOptionSetDefinitions";
                var optionSetId = "15c4b439-a473-ea11-a811-000d3af357bf";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{optionSetName}({optionSetId})");

                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        var subTypeList = new List<CaseStatus>();
                        var caseStatuses = JObject.Parse(results)["Options"];
                        foreach (var sObject in caseStatuses)
                        {
                            subTypeList.Add(new CaseStatus { Value = sObject["Value"].ToString(), Label = sObject["Label"]["UserLocalizedLabel"]["Label"].ToString() });
                        }
                        //var subTypeList = JsonConvert.DeserializeObject<List<CaseStatus>>(JObject.Parse(results)["Options"].ToString());
                        return subTypeList.Select(n => new SelectListItem { Value = n.Value, Text = n.Label }).OrderBy(m => m.Text);
                    }
                }
            }
            return null;
        }
    }
}
