using Hris.Application.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hris.Application.Services.Bootsraper
{
    public class ApplicationConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IMasterService, MasterService>();
        }
    }
}
