using Microsoft.Extensions.DependencyInjection;
using Serilog.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Infrastructure.ExtensionInfrastructure
{
    public static class SerilogExtensions
    {
        public static IServiceCollection AddCustomSerilogLogging(this IServiceCollection services,
            string generalLogFilePath = "C:")
        {

            // Configure Serilog to write logs to the specified file
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(generalLogFilePath, LogEventLevel.Information)
                .CreateLogger();

            // Set Serilog as the logger for the application
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                //.WriteTo.Console()
                .WriteTo.File(generalLogFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Use Serilog for ASP.NET Core's logging
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                //.WriteTo.Console()
                .WriteTo.File(generalLogFilePath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            services.AddSingleton(Log.Logger);

            return services;
        }
    }
}
