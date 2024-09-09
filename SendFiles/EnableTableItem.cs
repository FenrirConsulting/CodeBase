namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Models
{
    public class EnableTableItem
    {
        public string Status { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string Scope { get; set; } = string.Empty;
        public string Domain { get; set; } = string.Empty;
        public string SamAccount { get; set; } = string.Empty;
        public string DisableComment { get; set; } = string.Empty;
    }
}
