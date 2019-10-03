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
            ApplicationConfigurer.RegisterServices(services);
        }
    }
}
