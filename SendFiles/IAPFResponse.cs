namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    public class IAPFResponse
    {
        public string? SourceId { get; set; }
        public object? Request { get; set; }
        public string? RequestItem { get; set; }
        public string? AccessType { get; set; }
        public string? AccessSubtype { get; set; }
        public int RequestStatusCode { get; set; }
        public string? RequestStatusDesc { get; set; }
        public string? StatusComments { get; set; }
        public object? TaskDetails { get; set; }
        public object? ErrorDetails { get; set; }
        public string? iAPFid { get; set; }
    }
}
