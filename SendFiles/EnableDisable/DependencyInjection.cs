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
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.Repositories;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Authorization;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Models;
using Microsoft.AspNetCore.Session;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Data;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Data.Repositories.Interfaces;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Data.Repositories;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.IAPF.Services;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.IAPFDirectoryRepositories.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data.IAPFDirectoryRepositories;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable
{
    /// <summary>
    /// Provides dependency injection and configuration methods for the server application.
    /// </summary>
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public static class DependencyInjection
    {
        /// <summary>
        /// Adds server UI services to the service collection.
        /// </summary>
        /// <param name="services">The IServiceCollection to add services to.</param>
        /// <param name="config">The configuration object.</param>
        /// <returns>The updated IServiceCollection.</returns>
        public static IServiceCollection AddServerUI(this IServiceCollection services, IConfiguration config)
        {
            StandardServices(services, config);

            /// <summary>
            /// Add application specific services not included in standard service set from WebCoreUtility
            /// </summary>
            
            // Register ISharePointService
            services.AddSingleton<ISharePointService, SharePointService>();

            // Add Scoped DbContext with connection string from appConfiguration
            var appConfiguration = services.BuildServiceProvider().GetRequiredService<IAppConfiguration>();

            services.AddDbContextFactory<ScopedDbContext>(options =>
            {
                options.UseSqlServer(appConfiguration.ConnectionString);
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)));
            });

            // Add additional databases defined in AdditionalDatabases appConfiguration 
            services.AddDbContextFactory<IAPFDirectoryDbContext>(options =>
            {
                options.UseSqlServer(appConfiguration.AdditionalConnectionStrings.GetValueOrDefault("IAPFDirectory")
                    ?? throw new InvalidOperationException("Connection string for IAPFDirectory not found in AdditionalConnectionStrings."));

                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)));
            });

            // Add Additional Database Repositories
            services.AddScoped<IEnableDisableHistoryEntryRepository, EnableDisableHistoryEntryRepository>();
            services.AddScoped<IIAPFDirectoryADAcctDispositionActionRepository, IAPFDirectoryADAcctDispositionActionRepository>();

            // Services for connectivity to the RequestAPI
            services.AddScoped<APIServices>();
            services.AddHttpClient<APIServices>();
            services.AddScoped<IRequestBuilderService, RequestBuilderService>();

            return services;
        }

        /// <summary>
        /// Configures the server application.
        /// </summary>
        /// <param name="app">The WebApplication to configure.</param>
        /// <param name="config">The configuration object.</param>
        /// <returns>The configured WebApplication.</returns>
        public static WebApplication ConfigureServer(this WebApplication app, IConfiguration config)
        {
            StandardMiddleware(app, config);

            /// <summary>
            /// Add application specific configuration  not included in standard configuration set from WebCoreUtility
            /// </summary>
        
            return app;
        }

        private static void StandardServices(IServiceCollection services, IConfiguration config)
        {
            #region Application Services
            // Core application services
            services.AddControllers();
            services.AddRazorComponents()
                    .AddInteractiveServerComponents();
            services.AddHttpContextAccessor();
            services.AddScoped<ErrorHandlerService>();

            services.AddServerSideBlazor(options =>
            {
                options.DisconnectedCircuitRetentionPeriod = TimeSpan.FromMinutes(3);
                options.MaxBufferedUnacknowledgedRenderBatches = 10;
                options.JSInteropDefaultCallTimeout = TimeSpan.FromSeconds(60);
                options.DisconnectedCircuitMaxRetained = 100; // Limit the number of disconnected circuits
            })
            .AddHubOptions(options =>
            {
                options.ClientTimeoutInterval = TimeSpan.FromSeconds(60);
                options.KeepAliveInterval = TimeSpan.FromSeconds(15);
                options.HandshakeTimeout = TimeSpan.FromSeconds(15);
                options.MaximumReceiveMessageSize = 32 * 1024; // 32KB
            });

            #region Distributed Cache Services
            // Configure distributed cache for improved performance
            services.AddScoped<IDistributedCacheRepository, DistributedCacheRepository>();
            services.AddSingleton<IDistributedCache>(sp => new CustomDistributedCache(sp));
            #endregion

            // NLog Services for logging
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<ILogHelper, LogHelper>();

            // MudBlazor UI Components Added
            services.AddMudServices();
            services.AddMudBlazorSnackbar();
            services.AddMudServicesWithExtensions();
            services.AddScoped<IThemeService, ThemeService>();

            // Additional Services
            services.AddHttpClient();
            services.AddScoped<IRequestRefresh, RequestRefresh>();
            services.AddScoped<IdentityRedirectManager>();
            #endregion

            #region Static Configuration Services
            // Services for managing static configuration
            services.AddSingleton<LdapServerList>();
            services.AddSingleton<LdapRoleMappingConfig>();
            services.AddSingleton<NavLinksInfoList>();
            services.AddSingleton<RemoteScriptList>();
            services.AddSingleton<ServiceAccountList>();
            services.AddSingleton<IRegistryHelperService, RegistryHelperService>();

            // Holds Contents of AppSettings.JSON in a Service Class
            services.AddSingleton<IAppConfiguration>(sp =>
            {
                var registryHelper = sp.GetRequiredService<IRegistryHelperService>();
                var logHelper = sp.GetRequiredService<ILogHelper>();
                return new ServerAppConfiguration(config, registryHelper, logHelper);
            });

            // Holds Azure AD Options in a Service Class
            services.AddSingleton<IAzureAdOptions>(sp =>
            {
                var registryHelper = sp.GetRequiredService<IRegistryHelperService>();
                var logHelper = sp.GetRequiredService<ILogHelper>();
                var azureAdOptions = new AzureAdOptionsService(config, registryHelper, logHelper);

                return azureAdOptions;
            });

            services.AddScoped<IUserSettingsService, UserSettingsService>();
            #endregion

            #region Database Services
            // Add DbContext with connection string from appConfiguration
            var appConfiguration = services.BuildServiceProvider().GetRequiredService<IAppConfiguration>();
            services.AddDbContextFactory<AppDbContext>(options =>
            {
                options.UseSqlServer(appConfiguration.ConnectionString);
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)));
            });

            // Table Repository Services for data access
            services.AddScoped<ILDAPServerRepository, LDAPServerRepository>();
            services.AddScoped<IToolsConfigurationRepository, ToolsConfigurationRepository>();
            services.AddScoped<IRemoteScriptRepository, RemoteScriptRepository>();
            services.AddScoped<IServiceAccountRepository, ServiceAccountRepository>();
            services.AddScoped<IUserSettingsRepository, UserSettingsRepository>();
            services.AddScoped<IDistributedCacheRepository, DistributedCacheRepository>();

            // Preload Configuration into Static Classes before Authentication is Called
            services.AddHostedService<ConfigurationInitializationService>();
            #endregion

            #region Authentication Services
            // Configure authentication services
            services.AddScoped<IDomainUserGroupService, DomainUserGroupService>();
            services.AddScoped<IClaimsTransformation, CustomClaimsTransform>();
            services.AddCascadingAuthenticationState();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<ILdapAuthenticationService, LdapAuthenticationService>();
            services.AddScoped<RoleUpdateRequest>();

            // Cookies stored key ring for secure storage (switch to E:\ for Local Development)
            if (config["EnvironmentLoaded"]?.Equals("Development", StringComparison.OrdinalIgnoreCase) == true)
            {
                services.AddDataProtection()
               .PersistKeysToFileSystem(new DirectoryInfo(@"E:\IAPF\TOKENS"))
               .SetApplicationName(config["CookieName"]!);
            }
            else
            {
                services.AddDataProtection()
               .PersistKeysToDbContext<AppDbContext>()
               .SetApplicationName(config["CookieName"]!);
            }

            services.AddSingleton<ISessionStore>(provider =>
            {
                var distributedCache = provider.GetRequiredService<IDistributedCache>();
                var loggerFactory = provider.GetRequiredService<ILoggerFactory>();
                return new DistributedSessionStore(distributedCache, loggerFactory);
            });

            // Configure session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Persisted Cookies for Authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.Cookie.Name = config["CookieName"];
                    options.Cookie.Domain = config["DomainSite"];
                    options.Cookie.Path = "/";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Lax;
                    options.LoginPath = "/account/cookielogin";
                    options.ExpireTimeSpan = TimeSpan.FromHours(config.GetValue<int>("SessionTimeout", 1));
                    options.SlidingExpiration = true;
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
        }

        private static void StandardMiddleware(WebApplication app, IConfiguration config)
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
                app.UseExceptionHandler("/error", createScopeForErrors: true);
            }

            // Set up the middleware pipeline

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAntiforgery();

            app.MapControllers();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(typeof(WebCoreUtility._Imports).Assembly);
            #endregion
        }
    }
}