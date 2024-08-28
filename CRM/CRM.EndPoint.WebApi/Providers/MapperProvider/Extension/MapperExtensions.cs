using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Implementation;
using System.Reflection;

namespace CRM.EndPoint.WebApi.Providers.MapperProvider.Extension;

public static class MapperExtensions
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assembly);
        services.AddSingleton<IMapperAdapter, AutoMapperAdapter>();
        return services;
    }
}
