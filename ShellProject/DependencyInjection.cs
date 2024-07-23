using MudBlazor.Extensions;
using MudBlazor.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using Microsoft.AspNetCore.Components.Authorization;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Navigation;
using Microsoft.AspNetCore.Authentication;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.IdentityModel.Tokens;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Authorization;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authorization;
using Microsoft.Extensions.FileProviders;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell
{
    public static class DependencyInjection
    {
        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static IServiceCollection AddServerUI(this IServiceCollection services, IConfiguration config)
        {

            #region  Application Services
            services.AddControllers();
            services.AddRazorComponents()
                .AddInteractiveServerComponents();
            services.AddHttpContextAccessor();

            // Distributed Cache Services
            services.AddScoped<IDistributedCacheRepository, DistributedCacheRepository>();
            services.AddSingleton<IDistributedCache>(sp => new CustomDistributedCache(sp));

            // NLog Services
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ILogHelper, LogHelper>();

            // MudBlazor UI Components Added
            services.AddMudServices();
            services.AddMudBlazorSnackbar();
            services.AddMudServicesWithExtensions();
            services.AddScoped<ThemeService>();

            // Additional Services
            services.AddHttpClient();
            services.AddScoped<IRequestRefresh, RequestRefresh>();
            services.AddScoped<IdentityRedirectManager>();
            #endregion

            #region Static Configuration Services
            services.AddScoped<LdapRoleMappingConfig>(sp => new LdapRoleMappingConfig(config));
            services.AddSingleton(new LdapServerList(config));
            services.AddSingleton(new NavLinksInfoList(config));
            services.AddSingleton(new ViewModuleList(config));
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

            #region Database Services
            // Add DbContext with connection string from appConfiguration
            var appConfiguration = services.BuildServiceProvider().GetRequiredService<IAppConfiguration>();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(appConfiguration.ConnectionString);
            });

            // Table Repository Services
            services.AddScoped<IUserSettingsRepository, UserSettingsRepository>();
            services.AddScoped<IDistributedCacheRepository, DistributedCacheRepository>();
            #endregion

            #region Authentication Services
            services.AddScoped<IDomainUserGroupService, DomainUserGroupService>();
            services.AddScoped<IClaimsTransformation, CustomClaimsTransform>();
            services.AddCascadingAuthenticationState();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<ILdapAuthenticationService, LdapAuthenticationService>();
            services.AddScoped<RoleUpdateRequest>();

            // Cookies stored key ring
            services.AddDataProtection()
                    .PersistKeysToFileSystem(new DirectoryInfo(@"E:\IAPF\TOKENS"))
                    .SetApplicationName(config["CookieName"]!);

            // Persisted Cookies for Authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.Cookie.Name = config["CookieName"];
                    options.Cookie.Domain = config["DomainSite"];
                    options.Cookie.Path = "/";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.LoginPath = "/Account/cookieLogin";
                    options.Cookie.SameSite = SameSiteMode.Lax;
                });

            // Uses the Authentication Cookie as a Handler for Post Requests to other Applications
            services.AddTransient<CookieHandler>();
            services.AddHttpClient(config["CookieName"]!)
                    .AddHttpMessageHandler<CookieHandler>();

            services.AddHttpClient("AuthenticationAPI", c =>
            {
                c.BaseAddress = new Uri(config["AuthenticationAPIURL"]!);
            })
            .AddHttpMessageHandler<CookieHandler>();
            #endregion

            #region Authorization Services
            // Authorization Services, Use LdapRoleMappingConfig to Build a list of Policies and Roles
            services.AddAuthorization(options =>
            {
                var ldapRoleMappingConfig = services.BuildServiceProvider().GetRequiredService<LdapRoleMappingConfig>();
                foreach (var key in ldapRoleMappingConfig.LdapRoleMappings.Keys)
                {
                    options.AddPolicy(key, policy => policy.RequireRole(key));
                }

                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .RequireRole(ldapRoleMappingConfig.LdapRoleMappings.Keys.ToArray())
                    .Build();
            });
            #endregion

            return services;
        }

        // App Configuration Add-Ins
        public static WebApplication ConfigureServer(this WebApplication app, IConfiguration config)
        {
            #region Middleware Configuration
            // Set the Base HREF to AppSettings.JSON Property. Set to where the application needs to be mounted on IIS Server.
            var appConfiguration = app.Services.GetRequiredService<IAppConfiguration>();
            var baseUrl = appConfiguration.BaseUrl;
            app.UsePathBase(baseUrl);

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error", createScopeForErrors: true);
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAntiforgery();

            app.MapControllers();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(typeof(WebCoreUtility._Imports).Assembly);
            #endregion

            return app;
        }
    }
}
