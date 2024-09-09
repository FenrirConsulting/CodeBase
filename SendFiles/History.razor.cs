using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Application.Common.Configuration.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.NLog.LogService.Interface;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Data.Repositories.Interfaces;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Components.Pages
{
    /// <summary>
    /// Code-behind for the History page component.
    /// </summary>
    public partial class History : ComponentBase
    {
        #region Injected Services

        [Inject] private ISnackbar? _SnackBar { get; set; }
        [Inject] private ILogHelper? _Logger { get; set; }
        [Inject] private IAppConfiguration? _AppConfiguration { get; set; }
        [Inject] private IEnableDisableHistoryEntryRepository? _Repository { get; set; }
        [Inject] private IDialogService? _DialogService { get; set; }
        [Inject] private NavigationManager _NavigationManager { get; set; } = default!;
        [Inject] protected AuthenticationStateProvider _AuthenticationStateProvider { get; set; } = default!;

        #endregion

        #region Private Fields

        private string _selectedScope = "SingleAccount";
        private string _searchText = string.Empty;
        private List<EnableDisableHistoryEntry> _items = new List<EnableDisableHistoryEntry>();
        protected string UserDisplayName = string.Empty;

        #endregion

        #region Lifecycle Methods

        /// <summary>
        /// Initializes the component.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await this.LoadInitialData();

            var authState = await _AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity?.IsAuthenticated == true)
            {
                UserDisplayName = user.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty;
            }
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Set the Search Box Label based on Radio Selection
        /// </summary>
        private string GetSearchBoxLabel()
        {
            return _selectedScope switch
            {
                "SingleAccount" => "SAM Account",
                "AllAccounts" => "Employee Number",
                "SubmittedByMe" => "SAM Account",
                "SubmittedByAccount" => "Submitted By SAM Account",
                _ => "Search",
            };
        }

        /// <summary>
        /// For setting Read Only on Text Box when searching by Submitted by Me
        /// </summary>
        private void OnScopeChanged(string newScope)
        {
            _selectedScope = newScope;
            if (_selectedScope == "SubmittedByMe")
            {
                _searchText = UserDisplayName;
            }
            else
            {
                _searchText = string.Empty;
            }
        }

        /// <summary>
        /// Loads initial data for the component.
        /// </summary>
        private async Task LoadInitialData()
        {
            try
            {
                var entries = await _Repository!.GetAllAsync();
                _items = entries.ToList();
            }
            catch (Exception ex)
            {
                _SnackBar?.Add("Error loading initial data", Severity.Error);
                _Logger?.LogError("Error loading initial data", ex);
            }
        }

        /// <summary>
        /// Handles the search operation.
        /// </summary>
        private async Task SearchAsync()
        {
            try
            {
                _items = _selectedScope switch
                {
                    "SingleAccount" => (await _Repository!.GetBySAMAccount(_searchText)).ToList(),
                    "AllAccounts" => (await _Repository!.GetByEmployeeNumberAsync(_searchText)).ToList(),
                    "SubmittedByMe" => (await _Repository!.GetBySubmittedByAsync(UserDisplayName)).ToList(),
                    "SubmittedByAccount" => (await _Repository!.GetBySubmittedByAsync(_searchText)).ToList(),
                    _ => new List<EnableDisableHistoryEntry>(),
                };

                _SnackBar?.Add("Search completed found " + _items.Count + " Records." , Severity.Success);
            }
            catch (Exception ex)
            {
                _SnackBar?.Add("Error during search", Severity.Error);
                _Logger?.LogError("Error during search", ex);
            }
        }

        /// <summary>
        /// Refreshes all data.
        /// </summary>
        private async Task GetRefreshAllAsync()
        {
            try
            {
                var entries = await _Repository!.GetAllAsync();
                _items = entries.ToList();
                _SnackBar?.Add("Data refreshed", Severity.Success);
            }
            catch (Exception ex)
            {
                _SnackBar?.Add("Error refreshing data", Severity.Error);
                _Logger?.LogError("Error refreshing data", ex);
            }
        }

        /// <summary>
        /// Copies the table content to clipboard.
        /// </summary>
        private async Task CopyTable()
        {
            try
            {
                // TODO: Implement table copying logic
                await Task.Run(() =>
                {
                    // Simulating copy operation
                    _SnackBar?.Add("Table copied to clipboard", Severity.Success);
                });
            }
            catch (Exception ex)
            {
                _SnackBar?.Add("Error copying table", Severity.Error);
                _Logger?.LogError("Error copying table", ex);
            }
        }

        /// <summary>
        /// Opens the dialog for adding or editing an entry.
        /// </summary>
        /// <param name="entry">The entry to edit, or null for a new entry.</param>
        private async Task OpenDialog(EnableDisableHistoryEntry? entry)
        {
            var parameters = new DialogParameters();
            if (entry != null)
            {
                parameters.Add("Entry", entry);
            }

            var dialog = _DialogService!.Show<EntryDialog>(entry == null ? "Add New Entry" : "Edit Entry", parameters);
            var result = await dialog.Result;

            if (!result.Canceled)
            {
                await LoadInitialData();
            }
        }

        /// <summary>
        /// Deletes an entry from the repository.
        /// </summary>
        /// <param name="entry">The entry to delete.</param>
        private async Task DeleteEntry(EnableDisableHistoryEntry entry)
        {
            var confirm = await _DialogService!.ShowMessageBox(
                "Confirm Delete",
                "Are you sure you want to delete this entry?",
                yesText: "Delete", cancelText: "Cancel");

            if (confirm == true)
            {
                try
                {
                    await _Repository!.DeleteAsync(entry.RequestID!);
                    await LoadInitialData();
                    _SnackBar?.Add("Entry deleted successfully", Severity.Success);
                }
                catch (Exception ex)
                {
                    _SnackBar?.Add("Error deleting entry", Severity.Error);
                    _Logger?.LogError("Error deleting entry", ex);
                }
            }
        }

        #endregion
    }
}