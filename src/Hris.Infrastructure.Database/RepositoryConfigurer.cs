using Hris.Infrastructure.Database.Repositories;
using Hris.Infrastructure.Database.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Infrastructure.Database
{
    public class RepositoryConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
        }
    }
}
