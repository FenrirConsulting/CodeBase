using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using MudBlazor;
using System.Text.Json;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Pages
{
    /// <summary>
    /// Represents the main component for the Enable-Disable page.
    /// </summary>
    public partial class Main : ComponentBase, IDisposable
    {
        #region Dependency Injection

        [Inject] private ISnackbar? SnackBar { get; set; }
        [Inject] private ILogHelper? Logger { get; set; }
        [Inject] private IAppConfiguration? AppConfiguration { get; set; }
        [Inject] private IJSRuntime? JsRuntime { get; set; }
        [Inject] private ILdapAuthenticationService? LdapAuthenticationService { get; set; }
        [Inject] private IToolsConfigurationRepository? ToolsConfigurationRepository { get; set; }
        [Inject] private LdapServerList? LdapServerList { get; set; }

        #endregion

        #region Private Fields

        private string corpOmnicare = string.Empty;
        private string password = string.Empty;
        private string selectedInput = "Manual";
        private string selectedAction = "Disable";
        private string selectedScope = "SingleAccount";
        private string selectedDomain = string.Empty;
        private string samAccount = string.Empty;
        private string disableComment = string.Empty;
        private string fileName = string.Empty;
        private List<EnableTableItem> items = new List<EnableTableItem>();
        private List<DisableServer> disableServers = new List<DisableServer>();
        private DisableServer? omnicareDisableServer;
        private bool omnicareValidated = false;
        private string omnicareValidateGroup = string.Empty;
        private OmnicareServer omnicareServer = new OmnicareServer();
        private List<string> disableComments = new List<string>();
        private Dictionary<string, string> appConfigurations = new Dictionary<string, string>();

        #endregion

        #region Lifecycle Methods

        /// <summary>
        /// Initializes the component and loads initial data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadInitialData();
        }

        /// <summary>
        /// Performs cleanup of resources.
        /// </summary>
        public void Dispose()
        {
            // Implement resource cleanup if necessary
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Loads initial data for the component.
        /// </summary>
        private async Task LoadInitialData()
        {
            try
            {
                // Fetch all configurations for the application in a single query
                var configurations = await ToolsConfigurationRepository!.GetAllByApplicationAsync(AppConfiguration!.AppName);
                appConfigurations = configurations
                    .Where(c => c.Setting != null)  // Filter out any null keys
                    .ToDictionary(c => c.Setting!, c => c.Value ?? string.Empty);

                // Load Omnicare validate group
                omnicareValidateGroup = GetConfigurationValue("OmnicareValidateGroup");
                if (string.IsNullOrEmpty(omnicareValidateGroup))
                {
                    SnackBar?.Add("Could not load ValidateGroup", Severity.Error);
                    Logger?.LogMessage("OmnicareValidateGroup is null or empty");
                }

                // Load DisableServers
                LoadDisableServers();

                // Load DisableComments
                LoadDisableComments();

                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                SnackBar?.Add("Error loading initial data", Severity.Error);
                Logger?.LogError("Error loading initial data", ex);
            }
        }

        /// <summary>
        /// Retrieves a configuration value by key.
        /// </summary>
        /// <param name="key">The configuration key.</param>
        /// <returns>The configuration value if found, otherwise an empty string.</returns>
        private string GetConfigurationValue(string key)
        {
            if (appConfigurations.TryGetValue(key, out var value))
            {
                return value;
            }
            SnackBar?.Add($"Configuration '{key}' not found", Severity.Warning);
            Logger?.LogMessage($"Configuration '{key}' not found");
            return string.Empty;
        }

        /// <summary>
        /// Handles JSON deserialization exceptions.
        /// </summary>
        /// <param name="jsonEx">The JSON exception.</param>
        /// <param name="configName">The name of the configuration causing the exception.</param>
        private void HandleJsonException(JsonException jsonEx, string configName)
        {
            SnackBar?.Add($"Error parsing {configName} configuration: {jsonEx.Message}", Severity.Error);
            Logger?.LogError($"JSON parsing error in {configName} configuration: {jsonEx.Message}", jsonEx);
            Logger?.LogMessage($"Raw JSON causing the error: {GetConfigurationValue(configName)}");
        }

        /// <summary>
        /// Loads the DisableServers configuration.
        /// </summary>
        private void LoadDisableServers()
        {
            var disableServersConfig = GetConfigurationValue("EnableDisableServers");
            if (!string.IsNullOrEmpty(disableServersConfig))
            {
                try
                {
                    disableServers = JsonSerializer.Deserialize<List<DisableServer>>(disableServersConfig, new JsonSerializerOptions
                    {
                        AllowTrailingCommas = true,
                        ReadCommentHandling = JsonCommentHandling.Skip
                    }) ?? new List<DisableServer>();

                    // Process disableServers (existing logic)
                }
                catch (JsonException jsonEx)
                {
                    HandleJsonException(jsonEx, "DisableServers");
                }
            }
            else
            {
                SnackBar?.Add("Could not load DisableServers", Severity.Error);
                Logger?.LogMessage("EnableDisableServers configuration is null or empty");
            }
        }

        /// <summary>
        /// Loads the DisableComments configuration.
        /// </summary>
        private void LoadDisableComments()
        {
            var disableCommentsConfig = GetConfigurationValue("DisableComments");
            disableComments = new List<string>();  // Initialize the list

            if (!string.IsNullOrEmpty(disableCommentsConfig))
            {
                try
                {
                    var loadedComments = JsonSerializer.Deserialize<List<string>>(disableCommentsConfig, new JsonSerializerOptions
                    {
                        AllowTrailingCommas = true,
                        ReadCommentHandling = JsonCommentHandling.Skip
                    });

                    if (loadedComments != null)
                    {
                        disableComments.AddRange(loadedComments);
                    }
                }
                catch (JsonException jsonEx)
                {
                    HandleJsonException(jsonEx, "DisableComments");
                }
            }
            else
            {
                SnackBar?.Add("Could not load DisableComments", Severity.Error);
                Logger?.LogMessage("DisableComments configuration is null or empty");
            }

            // Always ensure "Other" is in the list
            if (!disableComments.Contains("Other"))
            {
                disableComments.Add("Other");
            }
        }

        /// <summary>
        /// Authenticates the user.
        /// </summary>
        private async Task AuthenticateAsync()
        {
            if (string.IsNullOrEmpty(omnicareValidateGroup))
            {
                SnackBar?.Add("ValidateGroup not loaded. Please try again later.", Severity.Error);
                return;
            }

            try
            {
                var (isAuthenticated, groups) = await LdapAuthenticationService!.ValidateCredentialsAndFetchGroupsAsync(
                    omnicareServer.Name,
                    omnicareServer.Server,
                    omnicareServer.Port,
                    omnicareServer.SearchBase,
                    omnicareServer.AdminSearchBase,
                    corpOmnicare,
                    password
                );

                if (!isAuthenticated)
                {
                    SnackBar?.Add("Invalid credentials", Severity.Warning);
                    omnicareValidated = false;
                }
                else
                {
                    omnicareValidated = groups.Contains(omnicareValidateGroup);
                    SnackBar?.Add(omnicareValidated ? "Omnicare Validated" : "NO Omnicare Admin Account Found",
                                  omnicareValidated ? Severity.Success : Severity.Warning);
                }
            }
            catch (Exception ex)
            {
                SnackBar?.Add("Authentication failed", Severity.Error);
                Logger?.LogError("Authentication error", ex);
                omnicareValidated = false;
            }
        }

        /// <summary>
        /// Resets the form to its initial state.
        /// </summary>
        private void ResetForm()
        {
            corpOmnicare = string.Empty;
            password = string.Empty;
            selectedInput = "Manual";
            selectedAction = "Disable";
            selectedScope = "SingleAccount";
            selectedDomain = string.Empty;
            samAccount = string.Empty;
            disableComment = string.Empty;
            fileName = string.Empty;
            items.Clear();
        }

        /// <summary>
        /// Validates the form inputs.
        /// </summary>
        /// <returns>True if the form is valid, otherwise false.</returns>
        private void ValidateForm()
        {
            // TODO: Implement form validation logic
            if(string.IsNullOrWhiteSpace(selectedDomain) || string.IsNullOrWhiteSpace(samAccount))
            {
                SnackBar?.Add("Please fill in all required fields", Severity.Warning);
                return;
            }

            var newItem = new EnableTableItem
            {
                Status = "Ready",
                Comment = "Account Found",
                Action = selectedAction,
                Scope = selectedScope,
                Domain = selectedDomain,
                SamAccount = samAccount,
                DisableComment = selectedAction == "Disable" ? disableComment : string.Empty
            };

            items.Add(newItem);

            SnackBar?.Add("Form validated and table updates", Severity.Success);
            StateHasChanged();
        }

        /// <summary>
        /// Executes the enable/disable action.
        /// </summary>
        private async Task ExecuteActionAsync()
        {

            try
            {
                if (items.Count == 0)
                {
                    SnackBar?.Add($"No items to process", Severity.Warning);
                    return;
                }

                var firstItem = items[0];

                string requestGUID = Guid.NewGuid().ToString();

                var requestModel = new RequestModel
                {
                    Source = "IAPFTools",
                    SourceId = requestGUID,
                    Request = requestGUID,
                    RequestItem = requestGUID,
                    CatalogItem = "AD Acct Disposition",
                    AccessType = "AD User Account",
                    AccessSubType = "Dispose",
                    ItemData = new RequestItemDataModel
                    {
                        EmployeeId = firstItem.Scope == "AllAccounts" ? firstItem.SamAccount : null,
                        AccountName = firstItem.Scope == "SingleAccount" ? firstItem.SamAccount : null,
                        AccountDomain = firstItem.Domain
                    }
                };

                var message = $"RequestModel created: \n" +
                              $"Source: {requestModel.Source}\n" +
                              $"SourceId: {requestModel.SourceId}\n" +
                              $"Request: {requestModel.Request}\n" +
                              $"RequestItem: {requestModel.RequestItem}\n" +
                              $"CatalogItem: {requestModel.CatalogItem}\n" +
                              $"AccessType: {requestModel.AccessType}\n" +
                              $"AccessSubType: {requestModel.AccessSubType}\n" +
                              $"EmployeeId: {requestModel.ItemData.EmployeeId}\n" +
                              $"AccountName: {requestModel.ItemData.AccountName}\n" +
                              $"AccountDomain: {requestModel.ItemData.AccountDomain}";


                SnackBar?.Add(message, Severity.Info, config =>
                {
                    config.ShowCloseIcon = true;
                    config.VisibleStateDuration = 10000;
                });

                // TODO: Implement actual enable/disable logic here

                await LoadInitialData(); // Refresh data
            }
            catch (Exception ex)
            {
                SnackBar?.Add($"Error executing {selectedAction} action", Severity.Error);
                Logger?.LogError($"Error executing {selectedAction} action", ex);
            }
        }

        /// <summary>
        /// Gets the text for the action button based on the selected scope.
        /// </summary>
        /// <returns>The button text.</returns>
        private string GetButtonText()
        {
            return selectedScope == "AllAccounts" ? "Enable / Disable" : selectedAction;
        }

        /// <summary>
        /// Handles the file input change event.
        /// </summary>
        /// <param name="e">The input file change event arguments.</param>
        private async Task OnInputFileChanged(InputFileChangeEventArgs e)
        {
            try
            {
                var file = e.File;
                if (file != null)
                {
                    fileName = file.Name;
                    // TODO: Process file contents
                    items.Add(new EnableTableItem
                    {
                        Status = "Pending",
                        Comment = "Imported from file",
                        Action = selectedAction,
                        Scope = selectedScope,
                        Domain = selectedDomain,
                        SamAccount = "ImportedAccount",
                        DisableComment = string.Empty
                    });
                    await InvokeAsync(StateHasChanged);
                }
            }
            catch (Exception ex)
            {
                SnackBar?.Add("Error processing file", Severity.Error);
                Logger?.LogError("Error processing file", ex);
            }
        }

        /// <summary>
        /// Handles the file import process.
        /// </summary>
        private async Task ImportFile()
        {
            if (string.IsNullOrEmpty(fileName))
            {
                SnackBar?.Add("Please select a file first", Severity.Warning);
                return;
            }

            try
            {
                // TODO: Implement file import logic here
                await Task.Delay(1000); // Simulating file processing
                SnackBar?.Add("File imported successfully", Severity.Success);
            }
            catch (Exception ex)
            {
                SnackBar?.Add("Error importing file", Severity.Error);
                Logger?.LogError("Error importing file", ex);
            }
        }

        /// <summary>
        /// Copies the table content to clipboard.
        /// </summary>
        private async Task CopyTable()
        {
            try
            {
                var tableContent = string.Join("\n", items.ConvertAll(item =>
                    $"{item.Status}\t{item.Comment}\t{item.Action}\t{item.Scope}\t{item.Domain}\t{item.SamAccount}\t{item.DisableComment}"));

                await JsRuntime!.InvokeVoidAsync("navigator.clipboard.writeText", tableContent);
                SnackBar?.Add("Table copied to clipboard", Severity.Success);
            }
            catch (Exception ex)
            {
                SnackBar?.Add("Error copying table", Severity.Error);
                Logger?.LogError("Error copying table", ex);
            }
        }

        #endregion
    }
}