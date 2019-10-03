using Hris.Application.Services.Bootsraper;
using Hris.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hris.Infrastructure.CrossCutting
{
    public static class IoCBootsrapper
    {
        public static void InitIoCBootsraper(this IServiceCollection services, IConfiguration configuration)
        {
            DatabaseBootsraper.InitDbBootsraper(services, configuration);
            ApplicationBootsraper.InitAppBootsraper(services);
        }

    }
}
