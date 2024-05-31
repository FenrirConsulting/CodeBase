using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;


namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IAppConfiguration ?AppConfiguration { get; set; }

        public DesignThemeModes Mode { get; set; }

        public OfficeColor Color { get; set; }
    }
}
