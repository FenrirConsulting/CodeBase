using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Themes;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Layouts
{
    public partial class AppBar : ComponentBase 
    {
        // Parameters and Proprerties
        [Parameter]
        public EventCallback OnSidebarToggled { get; set; }

        // Properties 
        [Parameter]
        public EventCallback<MudTheme> OnThemeToggled { get; set; }

        private bool _isLightMode = true;
        private MudTheme _currentTheme = new MudTheme();
       
        // Injected Services
        [Inject]
        public IAppConfiguration ?AppConfiguration { get; set; }

        [Inject]
        public AuthenticationStateProvider ?AuthenticationStateProvider { get; set; }

        [Inject] public NavigationManager? NavigationManager { get; set; }

        [Inject]
        public ThemeService? ThemeService { get; set; }

        private string ?userDisplayName;


        protected override async void OnParametersSet()
        {
            var authState = await AuthenticationStateProvider!.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity!.IsAuthenticated)
            {
                userDisplayName = user.Identity.Name;
            }

            StateHasChanged();
        }

        private async Task ToggleTheme()
        {
            _isLightMode = !_isLightMode;
            _currentTheme = !_isLightMode ? GenerateDarkTheme() : PaletteThemes.LightCVSTheme;
            await OnThemeToggled.InvokeAsync(_currentTheme);
        }

        private async Task Logout()
        {
            // Call the /Account/Logout controller
            NavigationManager!.NavigateTo("/Account/logout");
        }

        private MudTheme GenerateDarkTheme() =>
            PaletteThemes.DarkModernTheme;
    }
}
