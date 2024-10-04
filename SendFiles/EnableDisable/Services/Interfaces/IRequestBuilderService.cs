using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.IAPFRequest;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Services.Interfaces
{
    public interface IRequestBuilderService
    {
        RequestModel<RequestDisposePayloadModel> BuildDisposeRequest(List<EnableTableItem> items);
        RequestModel<RequestReinstatePayloadModel> BuildReinstateRequest(List<EnableTableItem> items);
    }
}
