using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Pages
{
    /// <summary>
    /// Represents the home page component for the EnableDisable tool.
    /// </summary>
    public partial class Home : ComponentBase
    {
        #region Injected Services
        [Inject] private IAppConfiguration? _appConfiguration { get; set; }
        [Inject] private IAzureAdOptions? _azureConfiguration { get; set; }
        [Inject] private NavigationManager? _navigationManager { get; set; }
        [Inject] private ILogHelper? _Logger { get; set; }
        [Inject] private AuthenticationStateProvider? _authenticationStateProvider { get; set; }
        #endregion

        #region Private Fields
        private bool IsLoading { get; set; } = false;

        #endregion

        #region Lifecycle Methods

        #endregion

        #region Private Methods

        #endregion
    }
}