using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities
{
    /// <summary>
    /// Represents an API permission with its name and associated scopes.
    /// </summary>
    public class ApiPermission
    {
        /// <summary>
        /// Gets or sets the name of the API.
        /// </summary>
        public string? ApiName { get; set; }

        /// <summary>
        /// Gets or sets the list of scopes for the API.
        /// </summary>
        public List<string>? Scopes { get; set; }
    }
}
