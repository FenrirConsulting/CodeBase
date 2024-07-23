using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Security.Claims;
using System.Web;

namespace CVSHealth.IAM.IAPF.Tools.ApplicationShell.Controllers
{
    [ApiController]
    [Route("/Account")]
    public class AuthenticationController : Controller
    {
        private readonly IAppConfiguration _appConfiguration;
        private readonly ILogHelper _logger;
        private readonly HttpClient _httpClient;
        private readonly IDistributedCache _cache;

        public AuthenticationController(
            IAppConfiguration appConfiguration,
            ILogHelper logger,
            IHttpClientFactory httpClientFactory,
            IDistributedCache cache)
        {
            _appConfiguration = appConfiguration;
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient(_appConfiguration.CookieName);
            _cache = cache;
        }

        [AllowAnonymous]
        [HttpGet("cookieLogin")]
        public async Task<IActionResult> Login(string returnUrl = "/")
        {
            returnUrl = _appConfiguration.ReturnURL;
            var authenticationUrl = $"{_appConfiguration.AuthenticationAPIURL}login";
            var callbackUrl = $"{returnUrl}Account/callback";

            var fullAuthenticationUrl = $"{authenticationUrl}?returnUrl={HttpUtility.UrlEncode(callbackUrl)}";

            try
            {
                return Redirect($"{authenticationUrl}?returnUrl={HttpUtility.UrlEncode(callbackUrl)}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred during login: ", ex);
                return StatusCode(500, "An error occurred during the login process.");
            }
        }

        [AllowAnonymous]
        [HttpGet("callback")]
        public IActionResult Callback(string returnUrl = "/")
        {
            returnUrl = _appConfiguration.ReturnURL;
            return Redirect(returnUrl);
        }

        [Authorize]
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrEmpty(userId))
            {
                await _cache.RemoveAsync($"user_roles_{userId}");
            }

            // Call logout on the AuthenticationAPI
            try
            {
                await _httpClient.GetAsync($"{_appConfiguration.AuthenticationAPIURL}logout");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred during logout: ", ex);
            }

            _logger.LogMessage($"User {userId} logged out successfully.");
            return Redirect("/");
        }
    }
}