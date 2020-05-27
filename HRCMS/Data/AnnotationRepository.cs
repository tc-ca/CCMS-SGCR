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
    public class AnnotationRepository : IAnnotationRepository
    {
        private readonly ILogger<AnnotationRepository> _logger;
        private readonly Dynamics _appSettings;
        private readonly IMapper _mapper;

        public AnnotationRepository(IMapper mapper, IOptions<Dynamics> settings)
        {
            _mapper = mapper;
            _appSettings = settings.Value;
        }       

        public async Task<AnnotationModel> GetAnnotationAsync(string annotationId)
        {
            using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
            {
                var entityName = "annotations";
                var response = await client.GetAsync($"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({annotationId})");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (result != null)
                    {
                        var note = JsonConvert.DeserializeObject<Annotation>(result, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        var attachment = _mapper.Map<AnnotationModel>(note);
                        return attachment;
                    }
                }
            }
            return null;
        }


        public async Task<string> UploadAttatchmentAsync(Annotation ques)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    //client.DefaultRequestHeaders.Add("Prefer", "return=representation");
                    //var entityName = "hr_questionandanswerses";
                    //dynamic jQuestion = new JObject();
                    //jQuestion.hr_answer = ques.hr_answer;
                    //jQuestion.hr_answeredon = DateTime.UtcNow.ToString();

                    //var caseContent = new StringContent(jQuestion.ToString(), Encoding.UTF8, "application/json");

                    //HttpRequestMessage updateRequest = new HttpRequestMessage(HttpMethod.Patch, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}({ques.hr_questionandanswersid})");
                    //updateRequest.Content = caseContent;

                    //var response = await client.SendAsync(updateRequest, HttpCompletionOption.ResponseHeadersRead);

                    //if (response.IsSuccessStatusCode)
                    //{
                    //    var result = await response.Content.ReadAsStringAsync();
                    //    if (result != null)
                    //    {
                    //        var entityId = response.Headers.GetValues("OData-EntityId").FirstOrDefault();
                    //        entityId = entityId.Substring(entityId.IndexOf("(") + 1, 36);
                    //        return entityId;
                    //    }
                    //}
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
