using CRM.EndPoint.WebApi.ApplicationBase.Extensions;
using CRM.EndPoint.WebApi.Databases.SQL.Data.Extensions;
using CRM.EndPoint.WebApi.Providers.BackgroundTask.Hangfire.Extension;
using CRM.EndPoint.WebApi.Providers.LoggerProvider.Configuration;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Extension;
using CRM.EndPoint.WebApi.Providers.SwaggerProvider.Extension;

namespace CRM.EndPoint.WebApi.HostApp.StartApp;

public static class ServiceConfguration
{
    public static WebApplication ServiceConfiguration(this WebApplicationBuilder builder)
    {
        IConfiguration configuration = builder.Configuration;
        
        builder.AddConsoleLogConfiguration();
        
        builder.Services.AddControllersWithViews();

        builder.Services.AddDatabaseContext(configuration);

        builder.Services.AddApplicationServices();

        builder.Services.AddMapper();

        builder.Services.AddHangfireService(configuration);

        builder.Services.AddSwaggerService(configuration);

        return builder.Build();
    }
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "api/{controller=Home}/{action=Index}/{id?}");

        app.UseHangfire();

        app.UseSwaggerConfig();

        return app;
    }
}