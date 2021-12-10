//using IdentityModel.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
                    //var authResult = tokenClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest()
                    //{
                    //    Scope = scope,
                    //    Address = authContextUrl,
                    //    ClientId = clientId,
                    //    ClientSecret = clientSecret
                    //});
                    //authHeader = new AuthenticationHeaderValue("Bearer", authResult.Result.AccessToken);

                    //--------------------------

                    var form = new Dictionary<string, string>
                        {
                            { "grant_type", "client_credentials" },
                            { "client_id", clientId },
                            { "client_secret", clientSecret },
                            { "scope", scope }
                        };

                    /* now tweak the http client */
                    tokenClient.DefaultRequestHeaders.Clear();
                    tokenClient.DefaultRequestHeaders.Add("cache-control", "no-cache");

                    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, authContextUrl);
                    req.Content = new FormUrlEncodedContent(form);
                    req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                    var tokenResponse = tokenClient.SendAsync(req).Result;
                    if (!tokenResponse.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException("Call to get Token with HttpClient failed.");
                    }
                    var jsonContent = tokenResponse.Content.ReadAsStringAsync().Result;
                    var tok = JsonConvert.DeserializeObject<Token>(jsonContent);
                    authHeader = new AuthenticationHeaderValue("Bearer", tok.AccessToken);
                    //authHeader = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSIsImtpZCI6ImEzck1VZ01Gdjl0UGNsTGE2eUYzekFrZnF1RSJ9.eyJpc3MiOiJodHRwOi8vdGNhcHBzdGVzdC50Yy5nYy5jYS9Db3JwLVNlcnYtR2VuLzMvdWF0L0hSV1NJLlB1YmxpYy5BdXRob3JpemF0aW9uL2lkZW50aXR5IiwiYXVkIjoiaHR0cDovL3RjYXBwc3Rlc3QudGMuZ2MuY2EvQ29ycC1TZXJ2LUdlbi8zL3VhdC9IUldTSS5QdWJsaWMuQXV0aG9yaXphdGlvbi9pZGVudGl0eS9yZXNvdXJjZXMiLCJleHAiOjE2MzkwOTA5NzksIm5iZiI6MTYzOTA4NzM3OSwiY2xpZW50X2lkIjoiQ0NNUyIsInNjb3BlIjoiaHJ3cy5wdWJsaWMifQ.R0HlAsaWcTTWY72GHnqZYW40OSZsQ74KYMTs-eC-yGS6N1A5I8QVutoDP5pMa9qImiDhgVnXqLFV42KXi1yIFbXBZfiQ30SAXWBNZcHISrlUS5utovnArlxCTEQdVltLNQlZ4J2U8OH3PS5HfFfa_KJQ1HU7in2CllY3a6o8uqIE6vxt9a9AooIbMjQxNMpRse0uflyjkjs2SPVL8RW-vux-VVKkmUr4nFuY2paMLkjtoahvrzn0IdZHgvF-YZYGICYxk8JdXEd9vZ_1M5UaVy7HvnGGiHVxF--nNiBqtuDyoxTKj-W5pn9r1gQARQlG8Nph9RxpenfKqA848CMlvw");


                }
            }

            protected async override Task<HttpResponseMessage> SendAsync(
                     HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
            {
                request.Headers.Authorization = authHeader;
                return await base.SendAsync(request, cancellationToken);
            }
        }

        class Token
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }
    }

    
}
