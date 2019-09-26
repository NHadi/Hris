using Hris.Organization.WebApi.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Organization.WebApi.Services
{
    public class ApplicationConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
        }
    }
}
