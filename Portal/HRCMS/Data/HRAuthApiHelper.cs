using IdentityModel.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace HRCMS.Data
{
    public class HRAuthApiHelper
    {      

        public static HttpClient GetHttpClient(HrApi settings)
        {
            string resourceUrl = settings.ResourceUrl;
            string authContextUrl = settings.AuthContextUrl;

            //HRCMS
            string clientId = settings.ClientId;
            string clientSecret = settings.ClientSecret;
            string scope = settings.Scope;

            string webApiUrl = $"{resourceUrl}/api/";

            try
            {
                HttpMessageHandler messageHandler;

                messageHandler = new OAuthMessageHandler(clientId, clientSecret, authContextUrl,scope,
                                  new HttpClientHandler());

                HttpClient httpClient = new HttpClient(messageHandler)
                {
                    BaseAddress = new Uri(webApiUrl),
                    Timeout = new TimeSpan(0, 2, 0)  //2 minutes
                };

                return httpClient;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        /// <summary>
        ///Custom HTTP message handler that uses OAuth authentication thru ADAL.
        /// </summary>
        class OAuthMessageHandler : DelegatingHandler
        {
            private AuthenticationHeaderValue authHeader;

            public OAuthMessageHandler(string clientId, string clientSecret, string authContextUrl,string scope,
                    HttpMessageHandler innerHandler)
                : base(innerHandler)
            {

                using (var tokenClient = new HttpClient())
                {
                    var authResult = tokenClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest()
                    {
                        Scope = scope,
                        Address = authContextUrl,
                        ClientId = clientId,
                        ClientSecret = clientSecret
                    });
                    authHeader = new AuthenticationHeaderValue("Bearer", authResult.Result.AccessToken);
                }               
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
