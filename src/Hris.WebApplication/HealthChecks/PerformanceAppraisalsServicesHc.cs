﻿using Hris.Common.Utlities.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hris.WebApplication.HealthChecks
{
    public class PerformanceAppraisalsServicesHc : IHealthCheck
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpCheck _httpCheck;
        public PerformanceAppraisalsServicesHc(IHttpCheck httpCheck)
        {
            _httpCheck = httpCheck;
            _configuration = ConfigurationManager.GetConfiguration("servicesettings.json");
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = new CancellationToken())
            => await _httpCheck.CheckHealthAsync(_configuration["api:performance-appraisals"] + "values/");
    }
}
