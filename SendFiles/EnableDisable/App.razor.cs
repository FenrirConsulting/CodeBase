using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using Microsoft.AspNetCore.Components;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable
{
    /// <summary>
    /// Represents the main application component for the AD Lookup tool.
    /// </summary>
    public partial class App
    {
        #region Injected Services

        /// <summary>
        /// The application configuration service.
        /// </summary>
        [Inject]
        public IAppConfiguration? AppConfiguration { get; set; }

        #endregion

        // Add any additional properties or methods here
    }
}
