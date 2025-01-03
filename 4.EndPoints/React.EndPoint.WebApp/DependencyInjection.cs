using React.EndPoint.WebApi;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddWebAppService(this WebApplicationBuilder builder)
    {
        // Add Razor Pages services
        builder.Services.AddRazorPages();

        return builder;
    }
    public static WebApplication UseWebAppPipeline(this WebApplication app)
    {

        app.UseDefaultFiles();
        app.MapStaticAssets();

        app.UseWebApiPipeline();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.MapStaticAssets();
        app.MapRazorPages()
           .WithStaticAssets();

        //app.MapFallbackToFile("/index.html");

        return app;
    }
}
