using Hris.Common.Utlities.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hris.WebApplication.HealthChecks
{
    public class AdministrationServicesHc : IHealthCheck
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpCheck _httpCheck;
        public AdministrationServicesHc(IHttpCheck httpCheck)
        {
            _httpCheck = httpCheck;
            _configuration = ConfigurationManager.GetConfiguration("servicesettings.json");
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = new CancellationToken())
            => await _httpCheck.CheckHealthAsync(_configuration["api:administration"] + "values/");
    }
}
