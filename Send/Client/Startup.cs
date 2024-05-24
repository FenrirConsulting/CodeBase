using Microsoft.FluentUI.AspNetCore.Components;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Interfaces;

namespace CVSHealth.IAM.IAPF.Test.BlazorAppTest.Client
{
    public class Startup
    {
        // Add Services to the Container
        public void ConfigureServices(IServiceCollection services, ClientAppSettings settings)
        {
            services.AddSingleton <IAppConfiguration>(new ClientAppConfiguration(settings));
            services.AddAuthorizationCore();
            services.AddFluentUIComponents();
        }
    }
}
