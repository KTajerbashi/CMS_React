using CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.Filter;
using CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.HostedService;
using Hangfire;
using Hangfire.SqlServer;

namespace CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.Extension;

public static class HangfireExtension
{
    public static IServiceCollection AddHangfireService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHangfire(options =>
        options.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                     .UseSimpleAssemblyNameTypeSerializer()
                     .UseRecommendedSerializerSettings()
                     .UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
                     {
                         CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                         SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                         QueuePollInterval = TimeSpan.Zero,
                         UseRecommendedIsolationLevel = true,
                         UsePageLocksOnDequeue = true,
                         DisableGlobalLocks = true
                     }));
        services.AddHangfireServer();
        services.AddSingleton<IHostBackgroundJobs, HostBackgroundJobs>();
        #region Type 1 Start Jobs
        //var serviceProvider = services.BuildServiceProvider();
        //var jobService = serviceProvider.GetService<IHostBackgroundJobs>();
        //jobService.Start();
        #endregion
        return services.StartJobs();
    }
    private static IServiceCollection StartJobs(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();
        var startTask = serviceProvider.GetService<IHostBackgroundJobs>();
        startTask.Start();
        return services;
    }

    public static void UseHangfire(this WebApplication app)
    {
        app.UseHangfireDashboard("/CRM_Dashboard");

        app.UseHangfireDashboard("/Admin_CRM_Dashboard", new DashboardOptions
        {
            Authorization = new[] { new AuthorizationFilter("Admin") },
            DashboardTitle = "Admin_CRM_Dashboard",
            //AppPath = "api/Home/Index",
            DarkModeEnabled = true,
            DefaultRecordsPerPage = 10,
            FaviconPath = "",
            DisplayStorageConnectionString = true,
            IgnoreAntiforgeryToken = false,
        });

        app.UseHangfireDashboard("/User_CRM_Dashboard", new DashboardOptions
        {
            Authorization = new[] { new AuthorizationFilter("User") },
            DashboardTitle = "User_CRM_Dashboard"
        });

        #region Type 2 Start Jobs
        //var serviceProvider = app.Services;
        //var startTask = serviceProvider.GetService<IHostBackgroundJobs>();
        //startTask.Start();
        #endregion

    }
}
