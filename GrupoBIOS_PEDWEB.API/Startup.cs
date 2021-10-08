using GrupoBIOS_PEDWEB.DM.DataBase;
using GrupoBIOS_PEDWEB.DM.DataBase.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GrupoBIOS_PEDWEB.API", Version = "v1" });
            });
            
            services.AddTransient<IConexionBD, ConexionInsightDB>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            ConfigureBMs(services);
        }


        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GrupoBIOS_PEDWEB.API v1"));
            }
            app.UseCors("AllowAll");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void ConfigureBMs(IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => a
            .FullName.StartsWith("GrupoBIOS_PEDWEB.BM"))
            .First();
            var classes = assembly.ExportedTypes.Where(a => a
             .FullName.Contains("BM"));
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
