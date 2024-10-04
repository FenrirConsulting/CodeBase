using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities
{
    /// <summary>
    /// Represents the AKeyLess configuration options.
    /// </summary>
    public class AKeyLessOptions
    {
        /// <summary>
        /// Gets or sets the Access ID.
        /// </summary>
        public string? AccessID { get; set; }

        /// <summary>
        /// Gets or sets the Access Type.
        /// </summary>
        public string? AccessType { get; set; }


        /// <summary>
        /// Gets or sets the Access Type.
        /// </summary>
        public string? AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        public string? Uri { get; set; }

        /// <summary>
        /// Gets or sets the Secret.
        /// </summary>
        public string? Secret { get; set; }

        /// <summary>
        /// Gets or sets the environment.
        /// </summary>
        public string? Env { get; set; }
    }
}
