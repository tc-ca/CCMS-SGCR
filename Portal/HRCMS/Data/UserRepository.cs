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
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace HRCMS.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<HRCaseRepository> _logger;
        private readonly ICaseTypeRepository _caseTypeRepository;
        private readonly HrApi _appSettings;
        private readonly IMapper _mapper;
               
        public UserRepository(ICaseTypeRepository caseTypeRepository, IMapper mapper, IOptions<HrApi> settings)
        {
            _caseTypeRepository = caseTypeRepository;
            _mapper = mapper;
            _appSettings = settings.Value;
        }


        [ResponseCache(NoStore = true)]
        public async Task<User> GetUserAsync(string userId)
        {
            var apiSubUrl = "/api/userinfo/";

#if DEBUG
            userId = "xiaowe";
            apiSubUrl = "/api/userinfoById/";
            //return new User { userId = "xiaowe", pri = "085757934", firstName = "Weiguang", lastName = "Xiao", email = "weiguang.xiao@034gc.onmicrosoft.com", appToken = "PhoenixForm" };
#endif
            using (var client = HRAuthApiHelper.GetHttpClient(_appSettings))
            {

                var response = await client.GetAsync(_appSettings.ResourceUrl+ apiSubUrl + userId);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (result != null)
                    {
                        var user = JsonConvert.DeserializeObject<User>(result);
                        return user;
                    }
                }
                else
                {
                    _logger.LogDebug("Failed to authenticate from HR Portal");
                }
            }
            return null;
        }


    }
}
