using System.IO;
using AutoMapper;
using Hris.Application.Services.Bootsraper;
using Hris.Application.Services.Mapper.Employees;
using Hris.Common;
using Hris.Infrastructure.CrossCutting;
using Hris.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace Hris.Master.WebApi
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
            services.InitCommonBootsraper();            
            services.InitIoCBootsraper(Configuration);
            services.AddAutoMapper(typeof(MappingProfile));

            string xmlPath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "swagger.xml");
            services.ConfigSwagger("Master Service", xmlPath);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // FOR UI Interface API
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", $"HRIS Microservices API {Global.API.Version}");
            });

            app.UseMvc();
        }
    }
}
