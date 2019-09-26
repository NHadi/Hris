using Hris.Common.API.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.API
{
    public class UrlApiFactory : IUrlApiFactory
    {
        private readonly IConfiguration _configuration;
        public UrlApiFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }       

        public string GetUrl(string serviceType)
        => _configuration.GetSection(serviceType).Value;
    }
}
