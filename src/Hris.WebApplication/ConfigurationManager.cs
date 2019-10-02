using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.WebApplication
{
    public class ConfigurationManager
    {
        public static IConfiguration GetConfiguration(string key)
        {
            var conf = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile(key)
           .Build();

            return conf;
        }
        
        
    }
}
