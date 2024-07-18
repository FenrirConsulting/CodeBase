using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CVSHealth.IAM.IAPF.Tools.AuthenticateAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/")]
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserPreferencesService? _userPreferencesService;
        private readonly IDomainUserGroupService _domainUserGroupService;
        private readonly LdapRoleMappingConfig _ldapRoleMappingConfig;
        private readonly IWebHostEnvironment _env;
        private readonly ILogHelper _logger;
        private readonly IAppConfiguration _appConfiguration;
        private readonly IUserSettingsRepository _userSettingsRepository;

        public AuthenticationController(IUserPreferencesService userPreferencesService, IHttpContextAccessor httpContextAccessor,
               IDomainUserGroupService domainUserGroupService, LdapRoleMappingConfig ldapRoleMappingConfig, IWebHostEnvironment env,
               ILogHelper logger, IAppConfiguration appConfiguration, IUserSettingsRepository userSettingsRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userPreferencesService = userPreferencesService;
            _domainUserGroupService = domainUserGroupService;
            _ldapRoleMappingConfig = ldapRoleMappingConfig;
            _env = env;
            _logger = logger;
            _appConfiguration = appConfiguration;
            _userSettingsRepository = userSettingsRepository;
        }

        // LoginUser with Sign In of Claims based on Role Membership
        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> Login(string returnUrl)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var username = User.Identity.Name;
                var lastAuthenticated = DateTime.UtcNow;
                var roles = _domainUserGroupService.GetRolesFromGroups(User);

                // Create claims with the Claim Name from Identity Name as well as adding roles and Last Authenticated Timestamp
                var claims = _domainUserGroupService.CreateClaims(User.Identity.Name!, roles, lastAuthenticated);



                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var authProperties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = lastAuthenticated.AddHours(_appConfiguration.CookieTimeout)
                };

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);



                _logger.LogMessage("Login User Identity Name : " + username);



                return Redirect(returnUrl);
            }
            else
            {
                return Unauthorized();
            }
        }

        [AllowAnonymous]
        [HttpGet("cookieLogin")]
        public async Task<IActionResult> CookieLogin()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                var username = User.Identity.Name;
                var lastAuthenticated = DateTime.UtcNow;
                var roles = _domainUserGroupService.GetRolesFromGroups(User);

                // Create claims with the Claim Name from Identity Name as well as adding roles and Last Authenticated Timestamp
                var claims = _domainUserGroupService.CreateClaims(User.Identity.Name!, roles, lastAuthenticated);
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                var authProperties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = lastAuthenticated.AddHours(_appConfiguration.CookieTimeout)
                };

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);

                _logger.LogMessage("Login User Identity Name : " + username);

                return Redirect(_appConfiguration.AuthenticationAPIURL);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { Message = "Logged Out" });
        }

        // Validation of Authenticated or Not
        [HttpGet("validate")]
        public async Task<IActionResult> Validate()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return Ok(User.Identity.Name);
            }

            return Unauthorized();
        }

        // Update Current Users Roles based on Passed In Roles
        [HttpPost("updateRoles")]
        public async Task<IActionResult> UpdateRoles([FromBody] RoleUpdateRequest request)
        {
            if (request.Roles == null)
            {
                return BadRequest("Roles cannot be null");
            }

            try
            {
                var identity = (ClaimsIdentity)User.Identity!;
                var username = identity.Name!;

                // Get existing additional roles
                var existingAdditionalRolesClaim = identity.FindFirst("AdditionalRoles");
                var existingAdditionalRoles = existingAdditionalRolesClaim != null
                    ? new HashSet<string>(existingAdditionalRolesClaim.Value.Split(',', StringSplitOptions.RemoveEmptyEntries))
                    : new HashSet<string>();

                // Add new roles
                foreach (var role in request.Roles)
                {
                    existingAdditionalRoles.Add(role);
                }

                // Create new AdditionalRoles claim
                var newAdditionalRolesClaim = new Claim("AdditionalRoles", string.Join(',', existingAdditionalRoles));

                // Create new identity with updated AdditionalRoles claim
                var newClaims = identity.Claims
                    .Where(c => c.Type != "AdditionalRoles")
                    .Append(newAdditionalRolesClaim)
                    .ToList();

                var newIdentity = new ClaimsIdentity(newClaims, identity.AuthenticationType);
                var newPrincipal = new ClaimsPrincipal(newIdentity);

                // Sign in with the new principal
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    newPrincipal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.UtcNow.AddHours(_appConfiguration.CookieTimeout)
                    });

                // Update the cache
                UserGroupsCache.AddUserRoles(username, request.Roles);

                return Ok(new
                {
                    Message = "Roles updated successfully",
                    AdditionalRoles = existingAdditionalRoles.ToList()
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Role Update Error", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating roles.");
            }
        }

        [HttpGet("claims")]
        public async Task<IActionResult> GetClaims()
        {
            if (User.Identity!.IsAuthenticated)
            {
                var userId = User.Identity!.Name;
                return Ok(User.Claims.Select(c => new { c.Type, c.Value }));
            }

            return Unauthorized();
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetUserSettings(string userid)
        {
            var userSettings = await _userSettingsRepository.GetUserSAMAsync(userid);
            if (userSettings == null)
            {
                return NotFound("Not Found");
            }

            return Ok(userSettings);
        }
    }
}