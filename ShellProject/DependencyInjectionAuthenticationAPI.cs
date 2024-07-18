using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authentication;


namespace CVSHealth.IAM.IAPF.Tools.AuthenticateAPI
{
    public static class DependencyInjection
    {
        // App Services Add-Ins
        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
            #region  Application Services
            services.AddHttpContextAccessor();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // NLog Services
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ILogHelper, LogHelper>();
            #endregion

            #region Static Configuration Services
            services.AddSingleton<LdapRoleMappingConfig>(sp => new LdapRoleMappingConfig(config));
            services.AddSingleton(new LdapServerList(config));
            services.AddSingleton<IRegistryHelperService, RegistryHelperService>();

            // Holds Contents of AppSettings.JSON in a Service Class
            services.AddSingleton<IAppConfiguration>(sp =>
            {
                var registryHelper = sp.GetRequiredService<IRegistryHelperService>();
                var logHelper = sp.GetRequiredService<ILogHelper>();
                return new ServerAppConfiguration(config, registryHelper, logHelper);
            });

            services.AddScoped<IUserPreferencesService, UserPreferencesService>();
            #endregion

            #region Authentication Services
            services.AddSingleton<IDomainUserGroupService, DomainUserGroupService>();
            services.AddScoped<IClaimsTransformation, CustomClaimsTransform>();

            // Cookies stored key ring
            services.AddDataProtection()
                    .PersistKeysToFileSystem(new DirectoryInfo(@"E:\IAPF\TOKENS"))
                    .SetApplicationName(config["CookieName"]!);

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                    {
                        options.Cookie.Name = config["CookieName"];
                        options.Cookie.Domain = config["DomainSite"];
                        options.Cookie.Path = "/";
                        options.LoginPath = "/cookieLogin";
                        options.Cookie.HttpOnly = true;
                        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                        options.Cookie.SameSite = SameSiteMode.Lax;
                        options.Events = new CookieAuthenticationEvents
                        {
                            OnValidatePrincipal = async context =>                             
                            {
                                context.ShouldRenew = true;
                            }
                        };
                    });

            // Uses the Authentication Cookie as a Handler for Post Requests to other Applications
            services.AddTransient<CookieHandler>();
            services.AddHttpClient(config["CookieName"]!)
                    .AddHttpMessageHandler<CookieHandler>();
            #endregion

            #region Authorization Services
            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = options.DefaultPolicy;
            });
            #endregion

            #region Database Services
            // Add DbContext with connection string from appConfiguration
            var appConfiguration = services.BuildServiceProvider().GetRequiredService<IAppConfiguration>();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(appConfiguration.ConnectionString);
            });

            // Table Repository Services
            services.AddScoped<IUserSettingsRepository, UserSettingsRepository>();
            #endregion

            return services;
        }

        // App Configuration Add-Ins
        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static WebApplication AddConfiguration(this WebApplication app, IConfiguration config)
        {
            #region Middleware Configuration
            var appConfiguration = app.Services.GetRequiredService<IAppConfiguration>();
            var baseUrl = appConfiguration.BaseUrl;
            app.UsePathBase(baseUrl);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"{baseUrl}swagger/v1/swagger.json", "Auth API V1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            #endregion

            return app;
        }
    }
}