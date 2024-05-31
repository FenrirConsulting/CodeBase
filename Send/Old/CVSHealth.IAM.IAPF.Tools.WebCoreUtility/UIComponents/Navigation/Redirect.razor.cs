using Microsoft.AspNetCore.Components;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Navigation
{
    public partial class Redirect : ComponentBase
    {
        [Inject]
        public NavigationManager ?NavigationManager { get; set; }

        [Parameter]
        public string? To { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            if (To != null) NavigationManager!.NavigateTo(To);
        }
    }
}
