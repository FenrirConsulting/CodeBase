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
        [MaxLength(50)]
        public string? RequestID { get; set; }

        /// <summary>
        /// Gets or sets the date of the history entry.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the status of the history entry.
        /// </summary>
        [MaxLength(20)]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the user who submitted the entry.
        /// </summary>
        [MaxLength(50)]
        public string? SubmittedBy { get; set; }

        /// <summary>
        /// Gets or sets the domain associated with the entry.
        /// </summary>
        [MaxLength(50)]
        public string? Domain { get; set; }

        /// <summary>
        /// Gets or sets the disabled status.
        /// </summary>
        [MaxLength(50)]
        public string? Disabled { get; set; }

        /// <summary>
        /// Gets or sets the SAM account name.
        /// </summary>
        [MaxLength(50)]
        public string? SAM { get; set; }

        /// <summary>
        /// Gets or sets the Organizational Unit.
        /// </summary>
        [MaxLength(100)]
        public string? OU { get; set; }

        /// <summary>
        /// Gets or sets the EA8 value.
        /// </summary>
        [MaxLength(50)]
        public string? EA8 { get; set; }

        /// <summary>
        /// Gets or sets the description of the history entry.
        /// </summary>
        [MaxLength(100)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the manager associated with the entry.
        /// </summary>
        [MaxLength(50)]
        public string? Manager { get; set; }

        /// <summary>
        /// Gets or sets the group memberships.
        /// </summary>
        [MaxLength(100)]
        public string? MemberOf { get; set; }

        /// <summary>
        /// Gets or sets the employee number.
        /// </summary>
        [MaxLength(20)]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// Gets or sets the mDBUseDefaults value.
        /// </summary>
        [MaxLength(50)]
        public string? MDBUseDefaults { get; set; }

        /// <summary>
        /// Gets or sets the msExchHideFromAddressList value.
        /// </summary>
        [MaxLength(50)]
        public string? MsExchHideFromAddressList { get; set; }

        #endregion
    }
}
