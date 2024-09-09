using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using RestSharp;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Services
{
    public class RequestAPIService
    {
        private readonly IAppConfiguration _appConfiguration;

        public RequestAPIService(IAppConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }

        public IAPFResponse PostRequestMessage(string token, string requestBodyJson)
        {
            var result = new IAPFResponse();

            string iapfRequestURL = _appConfiguration.DynamicValues["RequestAPIURL"];

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", requestBodyJson, ParameterType.RequestBody);

            var client = new RestClient(iapfRequestURL);
            var response = client.Execute(request);

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<IAPFResponse>(response.Content!);
            }

            return result!;
        }

        public async Task<string> GetAccessToken(string clientId, string secretValue, string tenantId)
        {
            string token = "";

            var app = ConfidentialClientApplicationBuilder
            .Create(clientId)
                   .WithClientSecret(secretValue)  // Once AKeyLess is working, can set to ServicePrincipalAKeylessKey
                   .WithAuthority(new Uri($"https://login.microsoftonline.com/{tenantId}"))
                   .Build();

            var result = await app.AcquireTokenForClient(new[] { "https://graph.microsoft.com/.default" })
                    .ExecuteAsync();

            token = result.AccessToken;

            return token;
        }
    }
}
