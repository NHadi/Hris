using Hris.Application.Services.Bootsraper;
using Hris.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Exceptions;
using Serilog.Sinks.Elasticsearch;
using System;

namespace Hris.Infrastructure.CrossCutting
{
    public static class IoCBootsrapper
    {
        public static void InitIoCBootsraper(this IServiceCollection services, IConfiguration configuration)
        {
            DatabaseBootsraper.InitDbBootsraper(services, configuration);
            ApplicationBootsraper.InitAppBootsraper(services);
        }

        public static void InitLogger(this IServiceCollection services, IConfiguration configuration)
        {
            var elasticUri = configuration["ElasticConfiguration:Uri"];

            // Create Serilog Elasticsearch logger
            Log.Logger = new LoggerConfiguration()
               .Enrich.FromLogContext()
               .Enrich.WithExceptionDetails()
               .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(elasticUri))
               {
                   AutoRegisterTemplate = true,
               })
               .CreateLogger();
        }

    }
}
