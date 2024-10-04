using System;
using System.ComponentModel.DataAnnotations;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    /// <summary>
    /// Represents a history entry in the system.
    /// </summary>
    public class EnableDisableHistoryEntry
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the unique request identifier.
        /// </summary>
        [Key]
        [MaxLength(100)]
        public string? RequestID { get; set; }

        /// <summary>
        /// Gets or sets the user who submitted the entry.
        /// </summary>
        [MaxLength(50)]
        public string? SubmittedBy { get; set; }

        #endregion
    }
}