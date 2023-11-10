using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdallCloud.Shared.Services
{
    public class GroupRequirement : IAuthorizationRequirement
    {
        public List<string> GroupNames { get; }
        public List<string> GroupDisplayNames { get; }

        public GroupRequirement(string groups)
        {
            GroupNames = groups.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => g.Trim())
                        .ToList();

            GroupDisplayNames = groups.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => g.Trim())
                        .ToList();
        }
    }
}
