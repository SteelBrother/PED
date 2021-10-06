using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers
{
    public class LogModel : ILogModel
    {
        private readonly IJSRuntime jSRuntime;
        private readonly IWebAssemblyHostEnvironment HostEnvironment;
        public LogModel(IJSRuntime jSRuntime, IWebAssemblyHostEnvironment HostEnvironment)
        {
            this.jSRuntime = jSRuntime;
            this.HostEnvironment = HostEnvironment;
        }
        public void RegistrarLog(string Log)
        {
            if (HostEnvironment.Environment != "Development")
            {
                _ = jSRuntime.GuardarLog(Log);
            }
            else
            {
                Console.WriteLine(Log);
            }
        }
    }
}
