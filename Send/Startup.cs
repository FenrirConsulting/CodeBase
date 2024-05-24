using Microsoft.FluentUI.AspNetCore.Components;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration;

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
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();

            services.AddFluentUIComponents();
            services.AddControllers();
            services.AddSingleton<IAppConfiguration>(new ServerAppConfiguration(Configuration));

            // Service to have run only in DEV mode.
            #if DEV

            #endif
        }

        // Setup App Configuration Items
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment()) 
            {
                app.UseWebAssemblyDebugging();
            }
            else 
            {
                app.UseExceptionHandler("/Error", createScopeForErrors: true);
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAntiforgery();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorComponents<CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Components.App>()
                    .AddAdditionalAssemblies(typeof(Program).Assembly)
                    .AddInteractiveServerRenderMode()
                    .AddInteractiveWebAssemblyRenderMode();
            });
        }

    }
}
