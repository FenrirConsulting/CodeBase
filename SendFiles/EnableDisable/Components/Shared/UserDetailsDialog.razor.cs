using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.IAPFTasks;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Reflection;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Shared
{
    public partial class UserDetailsDialog : ComponentBase
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; } = default!;

        [Parameter] public ADUserDetails UserDetails { get; set; } = default!;

        private void Close() => MudDialog.Close();

        private IEnumerable<KeyValuePair<string, string>> GetUserProperties(UserDetails? user)
        {
            if (user == null)
            {
                yield return new KeyValuePair<string, string>("Error", "No user details available");
                yield break;
            }

            foreach (PropertyInfo prop in user.GetType().GetProperties())
            {
                object? value = prop.GetValue(user, null);
                if (value is IEnumerable<String> stringList)
                {
                    yield return new KeyValuePair<string, string>(prop.Name, string.Join(", ", stringList));
                }
                else
                {
                    yield return new KeyValuePair<string, string>(prop.Name, value?.ToString() ?? "N/A");
                }
            }
        }
    }
}
