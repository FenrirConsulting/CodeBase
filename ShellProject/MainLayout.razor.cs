using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Themes;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Layouts
{
    public partial class MainLayout
    {
        // Injected Services
        [Inject]
        public ThemeService? ThemeService { get; set; }

        // Sidebar Open on Button Functionality
        private bool _sideBarOpen = true;
        private void ToggleSidebar() => _sideBarOpen = !_sideBarOpen;

        protected override void OnInitialized()
        {
            ThemeService!.ToggleTheme(PaletteThemes.LightCVSTheme);
        }

        private void ToggleTheme(MudTheme changedTheme)
        {
            ThemeService!.ToggleTheme(changedTheme);
            StateHasChanged();
        }
    }
}
