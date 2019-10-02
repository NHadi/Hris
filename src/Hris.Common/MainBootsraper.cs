using Hris.Common.API;
using Hris.Common.API.Interface;
using Hris.Common.Repositories;
using Hris.Common.Repositories.Interface;
using Hris.Common.Utlities.HealthChecks;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common
{
    public static class MainBootsraper
    {
        public static void InitCommonBootsraper(this IServiceCollection services)
        {
            services.AddTransient<IDbContextFactory, DbContextFactory>();
            services.AddTransient<IUrlApiFactory, UrlApiFactory>();

            RepositoryBootsraper.RegisterServices(services);
        }

        public static void InitHealthChecksBootsraper(this IServiceCollection services)
        {
            services.AddTransient<IHttpCheck, HttpCheck>();
        }


        public static void ConfigSwagger(this IServiceCollection services, string description, string xmlPath)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(Global.API.Version, new Info
                {
                    Version = Global.API.Version,
                    Title = "HRIS",
                    Description = $"HRIS :: {description}",
                    Contact = new Contact { Name = "Nurul Hadi", Email = "nurul.hadi@outlook.com", Url = "https://github.com/NHadi" }
                });

                x.IncludeXmlComments(xmlPath);
            });
        }
    }
}
