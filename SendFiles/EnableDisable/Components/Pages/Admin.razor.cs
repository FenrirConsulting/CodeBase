using Microsoft.AspNetCore.Components;
using MudBlazor;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.Identity.Client;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.IAPF.Services;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.Configuration;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Pages
{
    /// <summary>
    /// Represents the admin page component for managing tool configurations.
    /// </summary>
    public partial class Admin : ComponentBase
    {
        #region Injected Services
        [Inject] private IToolsConfigurationRepository? _toolsRepository { get; set; }
        [Inject] private IAppConfiguration? _appConfiguration { get; set; }
        [Inject] private ISnackbar? _snackbar { get; set; }
        [Inject] private ILogHelper? _logger { get; set; }
        [Inject] private IAzureAdOptions? _azureAdOptionsService { get; set; }
        [Inject] private APIServices? _requestAPIService { get; set; }
        #endregion

        #region Private Fields
        private List<ToolsConfiguration>? _toolConfigurations;
        private ToolsConfiguration? _editingItem;
        private bool _isDialogVisible;
        private DialogOptions _dialogOptions = new() { MaxWidth = MaxWidth.Medium, FullWidth = true };
        private bool _isNewItem;

        private string SecretValue = "";
        #endregion

        #region Lifecycle Methods
        protected override async Task OnInitializedAsync()
        {
            await LoadToolConfigurations();
        }
        #endregion

        #region Private Methods
        private async Task LoadToolConfigurations()
        {
            try
            {
                var configurations = await _toolsRepository!.GetAllByApplicationAsync(_appConfiguration!.AppName);
                _toolConfigurations = configurations.ToList();
            }
            catch (Exception ex)
            {
                _snackbar!.Add("Error fetching data", Severity.Error);
                _logger!.LogError("Error fetching data", ex);
            }
        }

        private void OpenEditor(ToolsConfiguration? item)
        {
            _isNewItem = item == null;
            _editingItem = _isNewItem ? new ToolsConfiguration { Application = _appConfiguration!.AppName } : item;
            _isDialogVisible = true;
        }

        private void CancelEdit()
        {
            _editingItem = null;
            _isDialogVisible = false;
            _isNewItem = false;
        }

        private async Task SaveChanges()
        {
            try
            {
                await _toolsRepository!.SetAsync(_editingItem!);
                _snackbar!.Add(_isNewItem ? "Item added successfully" : "Item updated successfully", Severity.Success);
                await LoadToolConfigurations(); // Refresh data
            }
            catch (Exception ex)
            {
                _snackbar!.Add($"Error {(_isNewItem ? "adding" : "updating")} item: {ex.Message}", Severity.Error);
                _logger!.LogError($"Error {(_isNewItem ? "adding" : "updating")} item:", ex);
            }
            finally
            {
                _editingItem = null;
                _isDialogVisible = false;
                _isNewItem = false;
            }
        }

        private async Task RemoveItem(long id)
        {
            try
            {
                await _toolsRepository!.RemoveAsync(new ToolsConfiguration { Id = id });
                _snackbar!.Add("Item removed successfully", Severity.Success);
                await LoadToolConfigurations(); // Refresh data
            }
            catch (Exception ex)
            {
                _snackbar!.Add($"Error removing item: {ex.Message}", Severity.Error);
                _logger!.LogError("Error removing item:", ex);
            }
        }

        private async Task TestConnection(string apiName)
        {
            try
            {
                AuthenticationResult authResult;
                string accessToken;

                authResult = await _requestAPIService!.GetAccessToken(
                    _azureAdOptionsService!.ClientId,
                    _azureAdOptionsService!.ServicePrincipalRegistryKey, 
                    _azureAdOptionsService!.TenantId,
                    apiName);

                accessToken = authResult.AccessToken;

                if (!string.IsNullOrEmpty(accessToken))
                {
                    _snackbar!.Add($"Connection successful to : {apiName} ", Severity.Success);
                }
                else
                {
                    _snackbar!.Add("Connection failed. Unable to acquire token.", Severity.Error);
                    _logger!.LogMessage("Azure App Registration connection test failed: Unable to acquire token");
                }
            }
            catch (Exception ex)
            {
                _snackbar!.Add($"Connection failed: {ex.Message}", Severity.Error);
                _logger!.LogError("Azure App Registration connection test failed", ex);
            }
        }

        /*
         private async Task AKeylessAccessKey()
        {
            try
            {
                var accessKeyTask = Task.Run(() => _credentialManager!.GetAzureCredential(
                    _azureAdOptionsService!.AKeyLess.AccessID!,
                    _azureAdOptionsService!.AKeyLess.AccessType!,
                    _azureAdOptionsService!.AKeyLess.AccessKey!,
                    _azureAdOptionsService!.AKeyLess.Uri!,
                    _azureAdOptionsService!.AKeyLess.Secret!,
                    _azureAdOptionsService!.AKeyLess.Env!
                ));

                var accessKey = await accessKeyTask;
                SecretValue = accessKey;

                var message = $"AccessKey: {accessKey}\n";
                _snackbar!.Add(message + "AkeylessClientID " + _appConfiguration!.DynamicValues["TestAkeylessClientId"], Severity.Success);
            }
            catch (Exception ex)
            {
                _snackbar!.Add($"Connection failed: {ex.Message}", Severity.Error);
                _logger!.LogError("Azure App Registration connection test failed", ex);
            }
        }

        private async Task TestAKeylessConnection()
        {
            try
            {
                AuthenticationResult authResult;
                string accessToken;

                authResult = await _requestAPIService!.GetAccessToken(
                _appConfiguration!.DynamicValues["TestAkeylessClientId"],
                SecretValue,
                _azureAdOptionsService!.TenantId,
                "AKeylessAPINotWorking");

                accessToken = authResult.AccessToken;

                if (!string.IsNullOrEmpty(accessToken))
                {
                    _snackbar!.Add("Connection successful! ", Severity.Success);
                    _logger!.LogMessage("Azure App Registration connection test successful");
                }
                else
                {
                    _snackbar!.Add("Connection failed. Unable to acquire token.", Severity.Error);
                    _logger!.LogMessage("Azure App Registration connection test failed: Unable to acquire token");
                }
            }
            catch (Exception ex)
            {
                _snackbar!.Add($"Connection failed: {ex.Message}", Severity.Error);
                _logger!.LogError("Azure App Registration connection test failed", ex);
            }
        }
        */

        #endregion
    }
}
