using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace CRM.EndPoint.WebApi.HostApp.StartApp;

public class StartApplication
{
    public static void RunApplication(Action action)
    {
        #region Start With NLog
        //var logger = LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();
        //try
        //{
        //    action();
        //}
        //catch (Exception ex)
        //{
        //    logger.Error(ex, "Application start-up failed");
        //    throw;
        //}
        //finally
        //{
        //    LogManager.Shutdown();
        //}
        #endregion

        #region Start With Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(
            outputTemplate: "{Timestamp:HH:mm:ss} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
            )// Use a predefined theme
            .CreateLogger();
        try
        {
            Log.Information("Start Application ... ");
            action();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, ex.Message);
            throw;
        }
        finally
        {
            Log.Information("Down Application ... ");
            Log.CloseAndFlush();
        }
        #endregion
    }
}
