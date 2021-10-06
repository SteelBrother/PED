using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers
{
    public class Settings : ISettings
    {
        private readonly HttpClient httpClient;
        public AppSetting AppSetting { get; set; }
        private readonly string JsonAmbiente;
        public Settings(HttpClient httpClient, IWebAssemblyHostEnvironment HostEnvironment)
        {
            this.httpClient = httpClient;
            JsonAmbiente = HostEnvironment.Environment.ToLower() == "Development" || string.IsNullOrWhiteSpace(HostEnvironment.Environment) ? "/appsettings.json" : $"/appsettings.{HostEnvironment.Environment.ToLower()}.json";
        }

        public async Task<string> GetApiUrl()
        {
            AppSetting = await httpClient.GetFromJsonAsync<AppSetting>(JsonAmbiente)
                                         .ConfigureAwait(false);
            return AppSetting.ApiUrl;
        }
    }
    public class AppSetting
    {
        public string ApiUrl { get; set; }
    }
}
