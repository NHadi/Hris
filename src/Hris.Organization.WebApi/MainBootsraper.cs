using Hris.Organization.WebApi.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Organization.WebApi
{
    public static class MainBootsraper
    {
        public static void InitAppBootsraper(this IServiceCollection services)
        {            
            ApplicationConfigurer.RegisterServices(services);
        }
    }
}
