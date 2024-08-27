using CRM.EndPoint.WebApi.Databases.SQL.Data.Extensions;

namespace CRM.EndPoint.WebApi.HostApp.StartApp;

public static class ServiceConfguration
{
    public static WebApplication ServiceConfiguration(this WebApplicationBuilder builder)
    {
        IConfiguration configuration = builder.Configuration;
        // Add services to the container.
        builder.Services.AddControllersWithViews();


        builder.Services.AddDatabaseContext(configuration);

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
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
        return app;
    }
}