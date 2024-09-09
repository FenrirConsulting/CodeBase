namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    /// <summary>
    /// Represents a response from the IAPF (Identity and Access Protection Framework) API.
    /// </summary>
    public class IAPFResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the source identifier of the request.
        /// </summary>
        public string? SourceId { get; set; }

        /// <summary>
        /// Gets or sets the request object.
        /// </summary>
        public object? Request { get; set; }

        /// <summary>
        /// Gets or sets the request item identifier.
        /// </summary>
        public string? RequestItem { get; set; }

        /// <summary>
        /// Gets or sets the access type.
        /// </summary>
        public string? AccessType { get; set; }

        /// <summary>
        /// Gets or sets the access subtype.
        /// </summary>
        public string? AccessSubtype { get; set; }

        /// <summary>
        /// Gets or sets the request status code.
        /// </summary>
        public int RequestStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the request status description.
        /// </summary>
        public string? RequestStatusDesc { get; set; }

        /// <summary>
        /// Gets or sets the status comments.
        /// </summary>
        public string? StatusComments { get; set; }

        /// <summary>
        /// Gets or sets the task details.
        /// </summary>
        public object? TaskDetails { get; set; }

        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        public object? ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the IAPF identifier.
        /// </summary>
        public string? IAPFId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IAPFResponse"/> class.
        /// </summary>
        public IAPFResponse()
        {
            // Default constructor
        }

        #endregion
    }
}