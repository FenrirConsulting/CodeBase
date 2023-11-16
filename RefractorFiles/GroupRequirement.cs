using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class GroupRequirement(string groups) : IAuthorizationRequirement
    {
        #region Properties
        public List<string> GroupNames { get; } = groups.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => g.Trim())
                        .ToList();
        public List<string> GroupDisplayNames { get; } = groups.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => g.Trim())
                        .ToList();
        #endregion
    }
}
