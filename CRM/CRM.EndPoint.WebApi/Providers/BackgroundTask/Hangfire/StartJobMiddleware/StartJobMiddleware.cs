using CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.HostedService;

namespace CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.StartJobMiddleware;

public class StartJobMiddleware
{
    private readonly RequestDelegate _next;

    public StartJobMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var serviceProvider = context.RequestServices;
        var myService = serviceProvider.GetService<IHostBackgroundJobs>();
        myService.Start();
        await _next(context);
    }
}
