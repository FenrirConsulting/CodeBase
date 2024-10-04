using CVSHealth.IAM.IAPF.Tools.EnableDisable.Models;
using CVSHealth.IAM.IAPF.Tools.EnableDisable.Services.Interfaces;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.Configuration;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities.IAPFRequest;

namespace CVSHealth.IAM.IAPF.Tools.EnableDisable.Services
{
    public class RequestBuilderService : IRequestBuilderService
    {

        public RequestModel<RequestDisposePayloadModel> BuildDisposeRequest(List<EnableTableItem> items)
        {
            var firstItem = items.First();
            string requestGUID = Guid.NewGuid().ToString();

            var disposePayload = new RequestDisposePayloadModel
            {
                EmployeeId = firstItem.Scope == "AllAccounts" ? firstItem.UserDetails!.EmployeeId : string.Empty
            };

            foreach (var item in items)
            {
                if (item.UserDetails?.Response?.Users != null)
                {
                    foreach (var user in item.UserDetails.Response.Users)
                    {
                        // Populate DisableAccounts
                        disposePayload.DisableAccounts.Add(new RequestDisposePayloadModel.DisableAccount
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain
                        });

                        // Populate SetAttributes
                        var setAttributes = new List<RequestDisposePayloadModel.SetAttribute>
                        {
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "Manager", AttributeValue = string.Empty },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "extensionAttribute8", AttributeValue = "DS" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBOverHardQuotaLimit", AttributeValue = "1024" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBOverQuotaLimit", AttributeValue = "1024" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBStorageQuota", AttributeValue = "1024" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBUseDefaults", AttributeValue = "FALSE" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "msExchHideFromAddressList", AttributeValue = "TRUE" },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "facsimileTelephoneNumber", AttributeValue = string.Empty },
                            new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "ShowInAddressBook", AttributeValue = string.Empty }
                        };
                        disposePayload.SetAttributes.AddRange(setAttributes);

                        // Populate HiddenFromAddressListsEnabled
                        disposePayload.HiddenFromAddressListsEnabled.Add(new RequestDisposePayloadModel.HiddenFromAddressListEnabled
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain
                        });

                        // Populate RemoveMembers
                        foreach (var group in user.MemberOf)
                        {
                            disposePayload.RemoveMembers.Add(new RequestDisposePayloadModel.RemoveMember
                            {
                                GroupName = group,
                                GroupDomain = user.Domain,
                                Account = new RequestDisposePayloadModel.DisableAccount
                                {
                                    AccountName = user.SamAccountName,
                                    AccountDomain = user.Domain
                                }
                            });
                        }

                        // Populate MoveAccounts
                        string targetOU = TermedUserOU.GetPurgeUsersOU(user.Domain);
                        disposePayload.MoveAccounts.Add(new RequestDisposePayloadModel.MoveAccount
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain,
                            TargetOU = targetOU
                        });
                    }
                }
            }

            return new RequestModel<RequestDisposePayloadModel>
            {
                Source = "IAPFToolsClient",
                SourceId = requestGUID,
                Request = requestGUID,
                RequestItem = requestGUID,
                CatalogItem = "AD Acct Disposition",
                AccessType = "AD User Account",
                AccessSubType = "Disable",
                ItemData = disposePayload
            };
        }

        public RequestModel<RequestReinstatePayloadModel> BuildReinstateRequest(List<EnableTableItem> items)
        {
            var firstItem = items.First();
            string requestGUID = Guid.NewGuid().ToString();

            var reinstatePayload = new RequestReinstatePayloadModel
            {
                EmployeeId = firstItem.Scope == "AllAccounts" ? firstItem.UserDetails!.EmployeeId : string.Empty
            };

            foreach (var item in items)
            {
                if (item.UserDetails?.Response?.Users != null)
                {
                    foreach (var user in item.UserDetails.Response.Users)
                    {
                        // Populate EnableAccounts
                        reinstatePayload.EnableAccounts.Add(new RequestReinstatePayloadModel.EnableAccount
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain
                        });

                        // Populate SetAttributes
                        var setAttributes = new List<RequestReinstatePayloadModel.SetAttribute>
                {
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "Description", AttributeValue = $"{DateTime.Now:yyyy-MM-dd} - Reinstated - previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "Manager", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "extensionAttribute8", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBOverHardQuotaLimit", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBOverQuotaLimit", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBStorageQuota", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "mDBUseDefaults", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "msExchHideFromAddressList", AttributeValue = "FALSE" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "facsimileTelephoneNumber", AttributeValue = "previous value from ADAcctDisposition_Actions table" },
                    new() { AccountName = user.SamAccountName, AccountDomain = user.Domain, AttributeName = "ShowInAddressBook", AttributeValue = "previous value from ADAcctDisposition_Actions table" }
                };
                        reinstatePayload.SetAttributes.AddRange(setAttributes);

                        // Populate HiddenFromAddressListsDisabled
                        reinstatePayload.HiddenFromAddressListsDisabled.Add(new RequestReinstatePayloadModel.HiddenFromAddressListDisabled
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain
                        });

                        // Populate AddMembers
                        // Note: You'll need to implement the logic to determine the previous group memberships
                        // For now, we'll use a placeholder method
                        var previousGroups = GetPreviousGroupMemberships(user.SamAccountName, user.Domain);
                        foreach (var group in previousGroups)
                        {
                            reinstatePayload.AddMembers.Add(new RequestReinstatePayloadModel.AddMember
                            {
                                GroupName = group,
                                GroupDomain = user.Domain,
                                Account = new RequestReinstatePayloadModel.EnableAccount
                                {
                                    AccountName = user.SamAccountName,
                                    AccountDomain = user.Domain
                                }
                            });
                        }

                        // Populate MoveAccounts
                        // Note: You'll need to implement the logic to determine the previous OU
                        string previousOU = GetPreviousOU(user.SamAccountName, user.Domain);
                        reinstatePayload.MoveAccounts.Add(new RequestReinstatePayloadModel.MoveAccount
                        {
                            AccountName = user.SamAccountName,
                            AccountDomain = user.Domain,
                            TargetOU = previousOU
                        });
                    }
                }
            }

            return new RequestModel<RequestReinstatePayloadModel>
            {
                Source = "IAPFToolsClient",
                SourceId = requestGUID,
                Request = requestGUID,
                RequestItem = requestGUID,
                CatalogItem = "AD Acct Disposition",
                AccessType = "AD User Account",
                AccessSubType = "Reinstate",
                ItemData = reinstatePayload
            };
        }

        // Placeholder method to get previous group memberships
        private List<string> GetPreviousGroupMemberships(string samAccountName, string domain)
        {
            // TODO: Implement logic to retrieve previous group memberships from ADAcctDisposition_Actions table
            return new List<string> { "previous values from ADAcctDisposition_Actions table" };
        }

        // Placeholder method to get previous OU
        private string GetPreviousOU(string samAccountName, string domain)
        {
            // TODO: Implement logic to retrieve previous OU from ADAcctDisposition_Actions table
            return "previous value from ADAcctDisposition_Actions table";
        }

    }
}
