using CRM.EndPoint.WebApi.Providers.SwaggerProvider.Options;
using Microsoft.OpenApi.Models;

namespace CRM.EndPoint.WebApi.Providers.SwaggerProvider.Extension;

public static class SwaggerExtension
{
    public static IServiceCollection AddSwaggerService(this IServiceCollection services,IConfiguration configuration)
    {
        var options = configuration.GetValue<SwaggerOption>("Swagger");
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        });
        return services;
    }
    public static void UseSwaggerConfig(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
    }
}
