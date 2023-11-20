using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Kiota.Abstractions.Authentication;
using MudBlazor.Services;
using Blazorise.RichTextEdit;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using HeimdallCloud.Infrastructure.Shared.DataAccess.Data;
using HeimdallCloud.Application.Business.Repository;
using HeimdallCloud.Application.Business.Repository.IRepository;
using HeimdallCloud.Shared.Services.IServices;
using HeimdallCloud.Shared.Services;
using HeimdallCloud.Shared.Models;
using HeimdallCloud.Infrastructure.Shared.DataAccess;

namespace HeimdallCloud
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        // Creates Services for Application
        public void ConfigureServices(IServiceCollection services)
        {
            #region Basic Services
            services.AddRazorPages()
                .AddMicrosoftIdentityUI();

            services.AddRazorComponents()
            .AddInteractiveServerComponents();

            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();
            #endregion

            #region Custom Component Library Services
            services.AddMudServices();
            services.AddBlazorise(options => { options.Immediate = true; }).AddBootstrapProviders().AddFontAwesomeIcons();
            services.AddBlazoriseRichTextEdit(options => { });
            #endregion

            #region Database Services and Interface Models
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductPriceRepository, ProductPriceRepository>();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddScoped<IPowerReportRepository, PowerReportRepository>();
            services.AddScoped<IIAMHAuthroizationSettingsRepository, IAMHAuthorizationSettingsRepository>();
            #endregion

            #region Authentication Services
            // OpenId Connect , Microsoft Identity Login. Loads in API Scopes
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
              .AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureAd"))
              .EnableTokenAcquisitionToCallDownstreamApi()
              .AddMicrosoftGraph(Configuration.GetSection("GraphAPI"))
              .AddInMemoryTokenCaches();

            // Trigger Intial Security Group Load on Token Validation
            services.Configure<MicrosoftIdentityOptions>(OpenIdConnectDefaults.AuthenticationScheme, options =>
            {
                options.Events ??= new OpenIdConnectEvents();
                options.Events.OnTokenValidated += async context =>
                {
                    var tokenService = context.HttpContext.RequestServices.GetRequiredService<ITokenService>();
                    await tokenService.InitializeUserGroups(context.Principal!);
                };
            });

            services.AddControllersWithViews()
                .AddMicrosoftIdentityUI();

            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });
            #endregion

            #region Authorization Services
            // Load Azure AD Options
            services.Configure<AzureAd>(Configuration.GetSection("AzureAd"));

            // User Session Service, Set Session Properties
            services.AddScoped<IUserSessionService, UserSessionService>();

            // User Group and Properties Service
            services.AddScoped<IUserGroupService, UserGroupService>();

            // Token Access Service
            services.AddScoped<ITokenService, TokenService>();

            // Authentication Provider Service
            services.AddScoped<IAccessTokenProvider, AuthenticationProvider>();

            // Load Authorization Settings
            services.AddSingleton<AuthorizationSettings>(AuthorizationSettings.GetInstance());
            services.AddScoped<IAuthorizationSettingsService, AuthorizationSettingsService>();
            services.AddHostedService<AuthorizationSettingsHostedService>();

            // Authorization Policy Builder
            services.AddAuthorization(options =>
            {
                // By default, all incoming requests will be authorized according to the default policy
                options.FallbackPolicy = options.DefaultPolicy;

            }).AddScoped<IAuthorizationHandler, GroupHandler>();
            #endregion

            #region API Services
            // Microsoft Graph API Service
            services.AddScoped<IGraphServiceAPI, GraphServiceAPI>();

            // PowerBi API Service
            services.AddScoped<IPowerBiServiceAPI, PowerBiServiceAPI>();
            #endregion
        }

        // Configures the Application Run Methods
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region App Run Steps
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseAntiforgery();

            app.Use(async (context, next) =>
            {
                var user = context.User;
                var tokenService = context.RequestServices.GetRequiredService<ITokenService>();

                if (await tokenService.IsTokenValid(user))
                {
                    await next.Invoke();
                }
                else
                {
                    context.Response.Redirect("/authentication/login");
                }

            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorComponents<App>().AddInteractiveServerRenderMode();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            #endregion
        }

    }
}
