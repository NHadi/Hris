using Hris.Domain.Aggregates.Master.Interface;
using Hris.Infrastructure.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

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
