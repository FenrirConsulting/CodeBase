using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    public class RequestModel
    {
        public string? Source { get; set; } = "IAPFTools";
        public string? SourceId { get; set; }
        public string? Request { get; set; }
        public string? RequestItem { get; set; }
        public string? CatalogItem { get; set; }
        public string? AccessType { get; set; }
        public string? AccessSubType { get; set; }
        public RequestItemDataModel ItemData { get; set; }

        public RequestModel()
        {
            ItemData = new RequestItemDataModel();
        }

        public static RequestModel FromJson(string json)
        {
            return JsonSerializer.Deserialize<RequestModel>(json)!;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class RequestItemDataModel
    {
        public string? EmployeeId { get; set; }
        public string? AccountName { get; set; }
        public string? AccountDomain { get; set; }
    }
}
