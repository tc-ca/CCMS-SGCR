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
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ILogger<QuestionRepository> _logger;
        private readonly Dynamics _appSettings;
        private readonly IMapper _mapper;

        public QuestionRepository(IMapper mapper, IOptions<Dynamics> settings)
        {
            _mapper = mapper;
            _appSettings = settings.Value;
        }

        public async Task<List<QuestionModel>> GetAllUnAnsweredQuestionsAsync(string pri)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "hr_questionandanswerses";
                var orderby = $"$orderby=createdon%20desc";
                var select = $"$select=hr_questionandanswersid,hr_question&$expand=hr_HRCase($select=hr_hrcaseid,hr_name)";
                var filter = $"$filter=hr_answer%20eq%20null%20and%20hr_HRCase/hr_pri%20eq%20{pri}";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}?{select}&{filter}&{orderby}");

                if (response.IsSuccessStatusCode)
                {
                    var results = await response.Content.ReadAsStringAsync();
                    if (results != null)
                    {
                        var questions = JsonConvert.DeserializeObject<List<Question>>(JObject.Parse(results)["value"].ToString(), new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        var questionModels = _mapper.Map<List<QuestionModel>>(questions);
                        return questionModels;
                    }
                }
            }
            return null;
        }

        //public async Task<Question> GetQuestionAsync(string questionId)
        //{
        //    using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
        //    {
        //        var entityName = "hr_questionandanswerses";
        //        var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({questionId})");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var result = await response.Content.ReadAsStringAsync();
        //            if (result != null)
        //            {
        //                var question = JsonConvert.DeserializeObject<Question>(result, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
        //                return question;
        //            }
        //        }
        //    }
        //    return null;
        //}


        public async Task<string> UpdateAnswerAsync(Question ques)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    //client.DefaultRequestHeaders.Add("Prefer", "return=representation");
                    var entityName = "hr_questionandanswerses";
                    dynamic jQuestion = new JObject();
                    jQuestion.hr_answer = ques.hr_answer;
                    jQuestion.hr_answeredon = DateTime.UtcNow.ToString();

                    var caseContent = new StringContent(jQuestion.ToString(), Encoding.UTF8, "application/json");

                    HttpRequestMessage updateRequest = new HttpRequestMessage(HttpMethod.Patch, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({ques.hr_questionandanswersid})");
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

    }
}
