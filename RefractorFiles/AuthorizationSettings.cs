using HeimdallCloud.Infrastructure.Shared.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Models
{
    public class AuthorizationSettings
    {
        #region Services & Delegates
        private static AuthorizationSettings? instance;
        private static readonly object _lock = new object();
        #endregion

        #region Properties
        public Dictionary<string, string>? Policies { get; private set; }

        public Dictionary<string, string>? Roles { get; private set; }

        public Dictionary<string, string>? ReportGroups { get; private set; }
        #endregion

        #region Methods
        private AuthorizationSettings()
        {
            Policies = new Dictionary<string, string>();
            Roles = new Dictionary<string, string>();
            ReportGroups = new Dictionary<string, string>();
        }
        #endregion

        #region Functions
        public static AuthorizationSettings GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new AuthorizationSettings();
                    }
                }
            }

            return instance;
        }

        public void PopulateSettings(IEnumerable<IAMHAuthorizationSettings> settings)
        {
            Policies!.Clear();
            Roles!.Clear();
            ReportGroups!.Clear();

            foreach (var setting in settings)
            {
                if (setting.Type == "Policies")
                {
                    Policies.Add(setting.Rule!, setting.Value!);
                }
                else if (setting.Type == "Roles")
                {
                    Roles.Add(setting.Rule!, setting.Value!);
                }

                ReportGroups.Add(setting.Rule!, setting.ReportsAssignmentGroup!);
            }
        }
        #endregion
    }
}
