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
using log4net;

namespace HRCMS.Data
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly HrApi _authSettings;
               
        public UserRepository(IMapper mapper, IOptions<HrApi> authSettings, IOptions<Dynamics> settings, ILog logger): base(mapper, settings, logger)
        {
            _authSettings = authSettings.Value;
        }


        [ResponseCache(NoStore = true)]
        public async Task<User> GetUserAsync(string userId)
        {
            var apiSubUrl = "/api/userinfo/";

#if DEBUG
            //userId = "36CVVQFSN2SYVAG";
            //apiSubUrl = "/api/userinfoById/";
            //return new User { userId = "xiaowe", pri = "085757934", firstName = "Weiguang", lastName = "Xiao", email = "weiguang.xiao@034gc.onmicrosoft.com", appToken = "PhoenixForm" };
#endif
            using (var client = HRAuthApiHelper.GetHttpClient(_authSettings))
            {

                var response = await client.GetAsync(_authSettings.ResourceUrl+ apiSubUrl + userId);

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
                    _logger.Error($"Authentication Fail! - Token:{userId}");
                }
            }
            return null;
        }


    }
}
