using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Layouts
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject]
        public IAppConfiguration? AppConfiguration { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}

