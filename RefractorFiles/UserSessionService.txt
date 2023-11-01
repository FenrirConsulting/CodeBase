using HeimdallCloud.Shared.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.Graph.Models.CallRecords;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class UserSessionService : IUserSessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession? Session
        {
            get
            {
                return _httpContextAccessor.HttpContext?.Session;
            }
        }

        public UserSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // Current Session UID
        public string? CurrentUID
        {
            get => Session?.GetString("CurrentUID")!;
            set
            {
                if (Session != null)
                {
                    Session.SetString("CurrentUID", value!);
                }
            }
        }

        // Current Session User DisplayName
        public string? CurrentUserDisplayName
        {
            get => Session?.GetString("CurrentUserDisplayName");
            set
            {
                if (Session != null)
                {
                    Session.SetString("CurrentUserDisplayName", value!);
                }
            }
        }

        // Current Session User Group Names
        public List<string>? UserGroupNames
        {
            get => GetSessionValue<List<string>>("UserGroupNames");
            set => SetSessionValue("UserGroupNames", value);
        }

        // CUrrent Session Authorized Policies
        public List<string>? AuthorizedPolicies
        {
            get => GetSessionValue<List<string>>("AuthorizedPolicies");
            set => SetSessionValue("AuthorizedPolicies", value);
        }

        private T? GetSessionValue<T>(String key)
        {
            var value = Session!.GetString(key);
            return value != null ? JsonConvert.DeserializeObject<T>(value) : default;
        }

        private void SetSessionValue<T>(String key, T value)
        {
            Session!.SetString(key, JsonConvert.SerializeObject(value));
        }
    }
}
