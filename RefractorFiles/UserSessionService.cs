using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Models.CallRecords;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class UserSessionService
        (IHttpContextAccessor httpContextAccessor, ILogger<UserSessionService> logger) : IUserSessionService
    {
        #region Services
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
        private readonly ILogger<UserSessionService> _logger = logger;

        private ISession? Session => _httpContextAccessor.HttpContext?.Session;
        #endregion

        #region Properties
        private const string CurrentUIDKey = "CurrentUID";
        private const string CurrentUserDisplayNameKey = "CurrentUserDisplayName";
        private const string UserGroupNamesKey = "UserGroupNames";
        private const string AuthorizedPoliciesKey = "AuthorizedPolicies";

        // Current Session UID
        public string? CurrentUID
        {
            get => Session?.GetString(CurrentUIDKey)!;
            set
            {
                Session?.SetString(CurrentUIDKey, value!);
            }
        }

        // Current Session User DisplayName
        public string? CurrentUserDisplayName
        {
            get => Session?.GetString(CurrentUserDisplayNameKey);
            set
            {
                Session?.SetString(CurrentUserDisplayNameKey, value!);
            }
        }

        // Current Session User Group Names
        public List<string>? UserGroupNames
        {
            get => GetSessionValue<List<string>>(UserGroupNamesKey);
            set => SetSessionValue(UserGroupNamesKey, value);
        }

        // CUrrent Session Authorized Policies
        public List<string>? AuthorizedPolicies
        {
            get => GetSessionValue<List<string>>(AuthorizedPoliciesKey);
            set => SetSessionValue(AuthorizedPoliciesKey, value);
        }
        #endregion

        #region Functions
        private T? GetSessionValue<T>(String key)
        {
            try
            {
                var value = Session!.GetString(key);
                return value != null ? JsonConvert.DeserializeObject<T>(value) : default;
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error deserializing session value for key {Key}", key);
                return default;
            }
        }

        private void SetSessionValue<T>(String key, T value)
        {
            try
            {
                Session!.SetString(key, JsonConvert.SerializeObject(value));
            }
            catch (JsonException ex)
            {
                _logger.LogError(ex, "Error serializing session value for key {Key}", key);
            }
        }
        #endregion

    }
}
