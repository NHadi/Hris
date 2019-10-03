using AutoMapper;
using Hris.Application.Services.Mapper.Employees;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Application.Services.Bootsraper
{
    public static class ApplicationBootsraper
    {
        public static void InitAppBootsraper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(EmployeeMappingProfile), typeof(MasterMappingProfile));

            ApplicationConfigurer.RegisterServices(services);
        }
    }
}
