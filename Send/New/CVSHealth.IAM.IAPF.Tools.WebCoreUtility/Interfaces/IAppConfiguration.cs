using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Interfaces
{
    public interface IAppConfiguration
    {
        string BaseUrl { get; }
        string ApplicationName { get; }
    }
}
