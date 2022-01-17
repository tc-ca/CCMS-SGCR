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
using log4net;

namespace HRCMS.Data
{
    public class AnnotationRepository : BaseRepository, IAnnotationRepository
    {
        public AnnotationRepository(IMapper mapper, IOptions<Dynamics> settings, ILog logger): base(mapper, settings, logger)
        {
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


        public async Task<string> UploadAttatchmentAsync(Annotation note)
        {
            try
            {
                using (var client = DynamicsApiHelper.GetHttpClient(_appSettings))
                {
                    //client.DefaultRequestHeaders.Add("Prefer", "return=representation");
                    var entityName = "annotations";
                    dynamic jNote = new JObject();
                    jNote.subject = note.subject;
                    jNote.notetext = note.notetext;
                    jNote.filename = note.filename;
                    jNote.isdocument = true;
                    jNote.documentbody = note.documentbody;
                    jNote["objectid_hr_hrcase@odata.bind"] = $"/hr_hrcases({note._objectid_value})";

                    var caseContent = new StringContent(jNote.ToString(), Encoding.UTF8, "application/json");

                    HttpRequestMessage uploadRequest = new HttpRequestMessage(HttpMethod.Post, $"{_appSettings.ResourceUrl}/api/data/v{_appSettings.ApiVersion}/{entityName}");
                    uploadRequest.Content = caseContent;

                    var response = await client.SendAsync(uploadRequest, HttpCompletionOption.ResponseHeadersRead);

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
