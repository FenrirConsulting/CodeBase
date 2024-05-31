using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents
{ 
    public partial class App
    {
        [Inject]
        public IAppConfiguration? AppConfiguration { get; set; }
    }
}
