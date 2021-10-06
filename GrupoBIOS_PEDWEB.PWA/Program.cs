using GrupoBIOS_PEDWEB.PWA.Helpers;
using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress), Timeout = TimeSpan.FromSeconds(15) });

            builder.Logging.SetMinimumLevel(LogLevel.Warning);

            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddSingleton<ILogModel, LogModel>();
            services.AddSingleton<IConexionRest, ConexionREST>();
            services.AddSingleton<IMostrarMensajes, MostrarMensajes>();
            services.AddSingleton<ISettings, Settings>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<RefrescarAppState>();
            services.AddSingleton<ILoggerProvider, CustomLoggerProvider>(services =>
            {
                var LogModel = services.GetService<ILogModel>();
                return new CustomLoggerProvider(LogModel);
            });

            ConfigureViewModels(services);
            ConfigureModels(services);
        }
        private static void ConfigureViewModels(IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a
                .FullName.StartsWith("GrupoBIOS_PEDWEB.PWA"))
                .First();
            var classes = assembly.ExportedTypes.Where(a => a
                 .FullName.Contains("_ViewModel"));
            foreach (Type t in classes)
            {
                foreach (Type i in t.GetInterfaces())
                {
                    services.AddTransient(i, t);
                }
            }
        }
        private static void ConfigureModels(IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => a
            .FullName.StartsWith("GrupoBIOS_PEDWEB.PWA"))
            .First();
            var classes = assembly.ExportedTypes.Where(a => a
                 .FullName.Contains("_Model"));
            foreach (Type t in classes)
            {
                foreach (Type i in t.GetInterfaces())
                {
                    services.AddTransient(i, t);
                }
            }

        }
    }
}
