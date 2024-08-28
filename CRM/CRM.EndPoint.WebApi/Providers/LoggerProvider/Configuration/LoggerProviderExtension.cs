using NLog.Extensions.Logging;
using Serilog;
namespace CRM.EndPoint.WebApi.Providers.LoggerProvider.Configuration;

public static class LoggerProviderExtension
{
    public static WebApplicationBuilder AddConsoleLogConfiguration(this WebApplicationBuilder builder)
    {
        #region Comment
        //// Optional: Configure logging
        //builder.Logging.ClearProviders(); // Clear existing logging providers
        //// Add console logging
        //builder.Logging.AddConsole(options =>
        //{
        //    options.LogToStandardErrorThreshold = LogLevel.Error;
        //    options.DisableColors = false; // Enable colored logs based on log level
        //});
        //builder.Logging.SetMinimumLevel(LogLevel.Information); // Set log level to Information
        //builder.Logging.AddJsonConsole(options =>
        //{
        //    options.IncludeScopes = true;
        //    options.TimestampFormat = "yyyy-MM-dd HH:mm:ss ";
        //    options.UseUtcTimestamp = true;
        //});
        #endregion

        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();
        return builder;
    }

    private static WebApplicationBuilder AddNLogProvider(this WebApplicationBuilder builder)
    {
        builder.Logging.AddNLog("nlog.config");
        return builder;
    }
    private static WebApplicationBuilder AddSerilogProvider(this WebApplicationBuilder builder)
    {
        return builder;
    }

}
