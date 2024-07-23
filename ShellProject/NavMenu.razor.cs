using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Layouts
{
    public partial class NavMenu
    {
        [Parameter] public bool SideBarOpen { get; set; }

        [Inject] NavLinksInfoList? Links { get; set; }
        [Inject] IAppConfiguration? AppConfiguration { get; set; }
        [Inject] NavigationManager? NavigationManager { get; set; }
        [Inject] AuthenticationStateProvider? _AuthenticationStateProvider { get; set; }
        [Inject] IRequestRefresh? _RequestRefresh { get; set; }
        [Inject] ThemeService? _ThemeService { get; set; }

        private Task<AuthenticationState>? _authenticationState { get; set; }

        protected override void OnInitialized()
        {
            _RequestRefresh!.RefreshRequested += RefreshComponent;
            _ThemeService!.OnChange += StateHasChanged;

            StateHasChanged();
        }

        // Trigger Nav Link Component Refresh from State Change elsewhere in Application
        private void RefreshComponent()
        {
            StateHasChanged();
        }

        private void Logout()
        {
            NavigationManager!.NavigateTo("/Account/Logout");
        }

        public void Dispose()
        {
            _ThemeService!.OnChange -= StateHasChanged;
        }

    }
}
