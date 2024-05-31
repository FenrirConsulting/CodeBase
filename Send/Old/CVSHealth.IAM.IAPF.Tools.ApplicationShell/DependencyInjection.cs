using Microsoft.FluentUI.AspNetCore.Components;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Layouts;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Pages;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell
{
    public static class DependencyInjection
    {
       
        public static IServiceCollection AddServerUI(this IServiceCollection services, IConfiguration config)
        {
            services.AddRazorComponents()
            .AddInteractiveServerComponents();

            services.AddFluentUIComponents();
            services.AddControllers();
            services.AddSingleton<IAppConfiguration>(new ServerAppConfiguration(config));
            services.AddHttpClient();

            // Service to have run only in DEV mode.
            #if DEV

            #endif

            return services;
        }

        public static WebApplication ConfigureServer(this WebApplication app, IConfiguration config)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
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
            app.MapControllers();
            app.MapRazorComponents<App>()
                    .AddInteractiveServerRenderMode()
                    .AddAdditionalAssemblies(typeof(MainLayout).Assembly);

            return app;
        }

    }
}
