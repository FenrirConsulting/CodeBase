using CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Shared;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.IAPFRequest;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.IAPFTasks;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.IAPF.Services;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Authentication.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Common.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Identity.Client;
using Microsoft.JSInterop;
using MudBlazor;
using System.Text.Json;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.UIComponents.Components;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Pages
{
    /// <summary>
    /// Represents the main component for the Enable-Disable page.
    /// </summary>
    public partial class Main : ComponentBase, IDisposable
    {
        #region Dependency Injection

        [Inject] private ISnackbar? _snackbar { get; set; }
        [Inject] private ILogHelper? _logger { get; set; }
        [Inject] private IAppConfiguration? _appConfiguration { get; set; }
        [Inject] private IAzureAdOptions? _azureAdOptions { get; set; }
        [Inject] private IJSRuntime? _jsRuntime { get; set; }
        [Inject] private ILdapAuthenticationService? _ldapAuthenticationService { get; set; }
        [Inject] private IToolsConfigurationRepository? _toolsConfigurationRepository { get; set; }
        [Inject] private LdapServerList? _ldapServerList { get; set; }
        [Inject] private APIServices? _requestAPIService { get; set; }
        [Inject] private IDialogService DialogService { get; set; } = default!;
        [Inject] private IRequestBuilderService _requestBuilderService { get; set; } = default!;

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
        private string selectedCriteria = "SAMAccount";
        private List<EnableTableItem> items = new List<EnableTableItem>();
        private List<DisableServer> disableServers = new List<DisableServer>();
        private DisableServer? omnicareDisableServer;
        private bool omnicareValidated = false;
        private bool isSingleAccountEnabled = true;
        private string omnicareValidateGroup = string.Empty;
        private OmnicareServer omnicareServer = new OmnicareServer();
        private List<string> disableComments = new List<string>();
        private Dictionary<string, string> appConfigurations = new Dictionary<string, string>();
        private bool isLoadingValidation = false;
        private bool isLoadingRequest = false;

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
                var configurations = await _toolsConfigurationRepository!.GetAllByApplicationAsync(_appConfiguration!.AppName);
                appConfigurations = configurations
                    .Where(c => c.Setting != null)  // Filter out any null keys
                    .ToDictionary(c => c.Setting!, c => c.Value ?? string.Empty);

                // Load Omnicare validate group
                omnicareValidateGroup = GetConfigurationValue("OmnicareValidateGroup");
                if (string.IsNullOrEmpty(omnicareValidateGroup))
                {
                    _snackbar?.Add("Could not load ValidateGroup", Severity.Error);
                    _logger?.LogMessage("OmnicareValidateGroup is null or empty");
                }

                // Load DisableServers
                LoadDisableServers();

                // Load DisableComments
                LoadDisableComments();

                await InvokeAsync(StateHasChanged);
            }
            catch (Exception ex)
            {
                _snackbar?.Add("Error loading initial data", Severity.Error);
                _logger?.LogError("Error loading initial data", ex);
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
            _snackbar?.Add($"Configuration '{key}' not found", Severity.Warning);
            _logger?.LogMessage($"Configuration '{key}' not found");
            return string.Empty;
        }

        /// <summary>
        /// Handles JSON deserialization exceptions.
        /// </summary>
        /// <param name="jsonEx">The JSON exception.</param>
        /// <param name="configName">The name of the configuration causing the exception.</param>
        private void HandleJsonException(JsonException jsonEx, string configName)
        {
            _snackbar?.Add($"Error parsing {configName} configuration: {jsonEx.Message}", Severity.Error);
            _logger?.LogError($"JSON parsing error in {configName} configuration: {jsonEx.Message}", jsonEx);
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
                _snackbar?.Add("Could not load DisableServers", Severity.Error);
                _logger?.LogMessage("EnableDisableServers configuration is null or empty");
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
                _snackbar?.Add("Could not load DisableComments", Severity.Error);
                _logger?.LogMessage("DisableComments configuration is null or empty");
            }

            // Always ensure "Other" is in the list
            if (!disableComments.Contains("Other"))
            {
                disableComments.Add("Other");
            }
        }

        /// <summary>
        /// Authenticates the Omnicare user.
        /// </summary>
        private async Task AuthenticateAsync()
        {
            if (string.IsNullOrEmpty(omnicareValidateGroup))
            {
                _snackbar?.Add("ValidateGroup not loaded. Please try again later.", Severity.Error);
                return;
            }

            try
            {
                var (isAuthenticated, groups) = await _ldapAuthenticationService!.ValidateCredentialsAndFetchGroupsAsync(
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
                    _snackbar?.Add("Invalid credentials", Severity.Warning);
                    omnicareValidated = false;
                }
                else
                {
                    omnicareValidated = groups.Contains(omnicareValidateGroup);
                    _snackbar?.Add(omnicareValidated ? "Omnicare Validated" : "NO Omnicare Admin Account Found",
                                  omnicareValidated ? Severity.Success : Severity.Warning);
                }

                // Enable the Omnicare domain option
                isSingleAccountEnabled = true;
            }
            catch (Exception ex)
            {
                _snackbar?.Add("Authentication failed", Severity.Error);
                _logger?.LogError("Authentication error", ex);
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
        private async Task ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(samAccount))
            {
                _snackbar?.Add("Please fill in all required fields", Severity.Warning);
                return;
            }

            isLoadingValidation = true;
            StateHasChanged();

            try
            {
                AuthenticationResult authResult;
                try
                {
                    authResult = await _requestAPIService!.GetAccessToken(
                        _azureAdOptions!.ClientId,
                        _azureAdOptions.ServicePrincipalRegistryKey,
                        _azureAdOptions.TenantId,
                        "AR-IAM-ART_IAPFTaskAPI");
                }
                catch (MsalException ex)
                {
                    _snackbar?.Add("Authentication Error", Severity.Error);
                    _logger?.LogError("MSAL Authentication Error", ex);
                    return;
                }
                catch (Exception ex)
                {
                    _snackbar?.Add($"Unexpected error during authentication: {ex.Message}", Severity.Error);
                    _logger?.LogError("Unexpected error during authentication", ex);
                    return;
                }

                if (string.IsNullOrEmpty(authResult.AccessToken))
                {
                    _snackbar?.Add("Access token is null or empty", Severity.Error);
                    return;
                }

                // Prepare ADUserDetails request
                var adUserDetailsRequest = new ADUserDetails
                {
                    EmployeeId = selectedCriteria == "EmployeeID" ? samAccount : string.Empty,
                    AccountName = selectedCriteria == "SAMAccount" ? samAccount : string.Empty,
                    AccountDomain = selectedScope == "SingleAccount" ? selectedDomain : string.Empty,
                    MemberOfDetails = true,
                    ManagerDetails = true
                };

                string requestBodyJson = JsonSerializer.Serialize(adUserDetailsRequest);

                try
                {
                    // Make API call to get user details
                    var response = await _requestAPIService.PostADUserAccountTaskAPIDetails(authResult.AccessToken, requestBodyJson);

                    // Process the response
                    if (response.SuccessCode)
                    {
                        var newItem = new EnableTableItem
                        {
                            Status = "Ready",
                            Comment = "Account Found",
                            Action = selectedAction,
                            Scope = selectedScope,
                            Domain = selectedScope == "SingleAccount" ? selectedDomain : string.Empty,
                            SamAccount = samAccount,
                            DisableComment = selectedAction == "Disable" ? disableComment : string.Empty,
                            UserDetails = response
                        };

                        items.Add(newItem);
                        _snackbar?.Add("User details retrieved successfully", Severity.Success);
                    }
                    else
                    {
                        _snackbar?.Add($"Error retrieving user details: {response.ErrorDesc}", Severity.Error);
                    }
                }
                catch (Exception ex)
                {
                    _snackbar?.Add("Error calling AD User Details API", Severity.Error);
                    _logger?.LogError("Error calling AD User Details API", ex);
                }
            }
            finally
            {
                isLoadingValidation = false;
                StateHasChanged();
            }
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
                    _snackbar?.Add($"No items to process", Severity.Warning);
                    return;
                }

                string jsonContent = string.Empty;

                if (selectedAction == "Disable")
                {
                    var disableRequest = _requestBuilderService.BuildDisposeRequest(items);
                    jsonContent = JsonSerializer.Serialize(disableRequest, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true
                    });
                }
                else if (selectedAction == "Enable")
                {
                    var reinstateRequest = _requestBuilderService.BuildReinstateRequest(items);
                    jsonContent = JsonSerializer.Serialize(reinstateRequest, new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true
                    });
                }
                else
                {
                    _snackbar?.Add("Invalid action selected", Severity.Warning);
                    return;
                }

                // Open the dialog to display the JSON
                var parameters = new DialogParameters { { "JsonContent", jsonContent } };
                DialogService.Show<JsonDialog>("Request JSON", parameters);

                // TODO: Implement actual enable/disable logic here

                await LoadInitialData(); // Refresh data
            }
            catch (Exception ex)
            {
                _snackbar?.Add($"Error executing {selectedAction} action", Severity.Error);
                _logger?.LogError($"Error executing {selectedAction} action", ex);
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
                _snackbar?.Add("Error processing file", Severity.Error);
                _logger?.LogError("Error processing file", ex);
            }
        }

        /// <summary>
        /// Handles the file import process.
        /// </summary>
        private async Task ImportFile()
        {
            if (string.IsNullOrEmpty(fileName))
            {
                _snackbar?.Add("Please select a file first", Severity.Warning);
                return;
            }

            try
            {
                // TODO: Implement file import logic here
                await Task.Delay(1000); // Simulating file processing
                _snackbar?.Add("File imported successfully", Severity.Success);
            }
            catch (Exception ex)
            {
                _snackbar?.Add("Error importing file", Severity.Error);
                _logger?.LogError("Error importing file", ex);
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

                await _jsRuntime!.InvokeVoidAsync("navigator.clipboard.writeText", tableContent);
                _snackbar?.Add("Table copied to clipboard", Severity.Success);
            }
            catch (Exception ex)
            {
                _snackbar?.Add("Error copying table", Severity.Error);
                _logger?.LogError("Error copying table", ex);
            }
        }

        private async Task OpenUserDetailsDialog(ADUserDetails userDetails)
        {
            var parameters = new DialogParameters
        {
            { "UserDetails", userDetails }
        };

            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.ExtraLarge };

            var dialog = DialogService.Show<UserDetailsDialog>("User Details", parameters, options);
            var result = await dialog.Result;
        }

        private async void DeleteItem(EnableTableItem item)
        {
            bool? result = await DialogService.ShowMessageBox(
                "Warning",
                "Remove this item from the list? Are you sure?",
                yesText: "Yes", cancelText:"Cancel");

            if (result == true)
            {
                items.Remove(item);
                StateHasChanged();
            }
        }
        #endregion
    }
}