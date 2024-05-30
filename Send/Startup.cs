using Microsoft.FluentUI.AspNetCore.Components;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.FileProviders;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents;

namespace CVSHealth.IAM.IAPF.Test.BlazorAppTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Add Services to the Container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorComponents()
            .AddInteractiveServerComponents();

            services.AddFluentUIComponents();
            services.AddControllers();
            services.AddSingleton<IAppConfiguration>(new ServerAppConfiguration(Configuration));

            // Service to have run only in DEV mode.
            #if DEV

            #endif
        }

        // Setup App Configuration Items
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IAppConfiguration appConfig)
        {
            // Middleware to set Path Base off BaseUrl in appsettings.json Configuration
            var baseUrl = appConfig.BaseUrl;
            app.UsePathBase(baseUrl);

            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error", createScopeForErrors: true);
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAntiforgery();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorComponents<App>()
                    .AddInteractiveServerRenderMode();
            });
        }
    }
}
