using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    /// <summary>
    /// Represents a request model for enable/disable operations.
    /// </summary>
    public class RequestModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the source of the request.
        /// </summary>
        public string Source { get; set; } = "IAPFTools";

        /// <summary>
        /// Gets or sets the source identifier.
        /// </summary>
        public string? SourceId { get; set; }

        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        public string? Request { get; set; }

        /// <summary>
        /// Gets or sets the request item identifier.
        /// </summary>
        public string? RequestItem { get; set; }

        /// <summary>
        /// Gets or sets the catalog item.
        /// </summary>
        public string? CatalogItem { get; set; }

        /// <summary>
        /// Gets or sets the access type.
        /// </summary>
        public string? AccessType { get; set; }

        /// <summary>
        /// Gets or sets the access subtype.
        /// </summary>
        public string? AccessSubType { get; set; }

        /// <summary>
        /// Gets or sets the item data.
        /// </summary>
        public RequestItemDataModel ItemData { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestModel"/> class.
        /// </summary>
        public RequestModel()
        {
            ItemData = new RequestItemDataModel();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deserializes a JSON string to a <see cref="RequestModel"/> object.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A <see cref="RequestModel"/> object.</returns>
        public static RequestModel FromJson(string json)
        {
            return JsonSerializer.Deserialize<RequestModel>(json) ?? new RequestModel();
        }

        /// <summary>
        /// Serializes the current <see cref="RequestModel"/> object to a JSON string.
        /// </summary>
        /// <returns>A JSON string representation of the object.</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        #endregion
    }

    /// <summary>
    /// Represents the item data for a request.
    /// </summary>
    public class RequestItemDataModel
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        public string? EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        public string? AccountName { get; set; }

        /// <summary>
        /// Gets or sets the account domain.
        /// </summary>
        public string? AccountDomain { get; set; }
    }
}