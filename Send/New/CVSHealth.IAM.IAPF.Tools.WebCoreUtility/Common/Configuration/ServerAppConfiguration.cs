using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using Microsoft.Extensions.Configuration;


namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration
{
    public  class ServerAppConfiguration : IAppConfiguration
    {
        private readonly IConfiguration _configuration;

        public ServerAppConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string BaseUrl => _configuration["BaseUrl"]!;
        public string ApplicationName => _configuration["ApplicationName"]!;
    }
}
