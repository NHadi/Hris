using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.WebApplication.HealthChecks
{
    public static class HcBootsraper
    {
        public static void SetHealtCheck(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
               .AddCheck<OrganizationServicesHc>("Organization HTTP Check")
               .AddCheck<AdministrationServicesHc>("Administration HTTP Check")
               .AddCheck<AttendanceServicesHc>("Attendance HTTP Check")
               .AddCheck<TrainingServicesHc>("Training HTTP Check")
               .AddCheck<LeavingServicesHc>("Leaving HTTP Check")
               .AddCheck<MedicalServicesHc>("Medical HTTP Check")
               .AddCheck<PayrollServicesHc>("Payroll HTTP Check")
               .AddCheck<TravellingServicesHc>("Travelling HTTP Check")
               .AddCheck<PerformanceAppraisalsServicesHc>("Performance Appraisals HTTP Check")
               .AddCheck<RecruitmentServicesHc>("Recruitment HTTP Check")
               .AddCheck<MasterServicesHc>("Master HTTP Check")              
            .AddSqlServer(configuration["ConnectionStrings:HrisConnection"]);
        }
    }
}
