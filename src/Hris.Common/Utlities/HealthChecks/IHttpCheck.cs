using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hris.Common.Utlities.HealthChecks
{
    public interface IHttpCheck
    {
        Task<HealthCheckResult> CheckHealthAsync(string url);
    }
}
