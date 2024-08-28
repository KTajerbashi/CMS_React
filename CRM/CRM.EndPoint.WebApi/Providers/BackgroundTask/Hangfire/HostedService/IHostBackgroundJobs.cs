
using Hangfire;
using Serilog;

namespace CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.HostedService;

public interface IHostBackgroundJobs
{
    void Start();
}
public class HostBackgroundJobs : IHostBackgroundJobs
{
    private readonly IBackgroundJobClient _backgroundJobClient;
    private readonly ILogger<HostBackgroundJobs> _logger;
    public HostBackgroundJobs(IBackgroundJobClient backgroundJobClient, ILogger<HostBackgroundJobs> logger)
    {
        _backgroundJobClient = backgroundJobClient;
        _logger = logger;
    }

    public void Start()
    {
        _backgroundJobClient.Enqueue(() => SendStartupEmail());
    }
    public void SendStartupEmail()
    {
        _logger.LogInformation("============================");
        _logger.LogInformation($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogError($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogCritical($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogDebug($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogWarning($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogTrace($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        _logger.LogInformation("============================");


        Log.Information("============================");
        Log.Information($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Error($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Fatal($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Debug($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Warning($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Verbose($"SendStartupEmail ... {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
        Log.Information("============================");
    }
}