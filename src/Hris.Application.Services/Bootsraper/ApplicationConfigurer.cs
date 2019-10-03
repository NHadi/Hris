using Hris.Application.Services.Master;
using Hris.Domain.Aggregates.Master.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Hris.Application.Services.Bootsraper
{
    public class ApplicationConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {            
            services.AddTransient<IMasterService, MasterService>();
        }
    }
}
