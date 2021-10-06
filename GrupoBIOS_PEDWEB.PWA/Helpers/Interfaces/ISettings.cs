using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces
{
    public interface ISettings
    {
        Task<string> GetApiUrl();
    }
}
