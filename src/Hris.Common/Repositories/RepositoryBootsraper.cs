using Hris.Common.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.Repositories
{
    public class RepositoryBootsraper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IDapperRepository<>), typeof(DapperRepository<>));
            services.AddScoped(typeof(IEfRepository<>), typeof(EfRepository<>));
        }
    }
}
