using Hris.Common;
using Hris.Infrastructure.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Infrastructure.Database
{
    public static class Bootsraper
    {
        public static void InitDbBootsraper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HrisContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(Global.DbConnection.HrisConnection)));

            RepositoryConfigurer.RegisterServices(services);            
        }
    }
}
