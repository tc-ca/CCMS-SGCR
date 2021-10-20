using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class DynamicsApiHelper
    {      

        public static HttpClient GetHttpClient(Dynamics settings)
        {
            string resourceUrl = settings.ResourceUrl;
            string authContextUrl = settings.AuthContextUrl;

            //HRCMS
            string clientId = settings.ClientId;
            string clientSecret = settings.ClientSecret;
            string tenantId = settings.TenantId;
            string apiVersion = settings.ApiVersion;
            string webApiUrl = $"{resourceUrl}/api/data/v{apiVersion}/";

            try
            {
                HttpMessageHandler messageHandler;


                messageHandler = new OAuthMessageHandler(resourceUrl, clientId, clientSecret, tenantId, authContextUrl,
                                  new HttpClientHandler());


                HttpClient httpClient = new HttpClient(messageHandler)
                {
                    BaseAddress = new Uri(webApiUrl),
                    Timeout = new TimeSpan(0, 2, 0)  //2 minutes
                };

                return httpClient;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        ///Custom HTTP message handler that uses OAuth authentication thru ADAL.
        /// </summary>
        class OAuthMessageHandler : DelegatingHandler
        {
            private AuthenticationHeaderValue authHeader;

            public OAuthMessageHandler(string serviceUrl, string clientId, string clientSecret, string tenantId, string authContextUrl,
                    HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
                var credentials = new ClientCredential(clientId, clientSecret);
                var authContext = new AuthenticationContext(authContextUrl + tenantId);
                var authResult = authContext.AcquireTokenAsync(serviceUrl, credentials);

                authHeader = new AuthenticationHeaderValue("Bearer", authResult.Result.AccessToken);
            }

            protected async override Task<HttpResponseMessage> SendAsync(
                     HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
            {
                request.Headers.Authorization = authHeader;
                return await base.SendAsync(request, cancellationToken);
            }
        }
    }

    
}
