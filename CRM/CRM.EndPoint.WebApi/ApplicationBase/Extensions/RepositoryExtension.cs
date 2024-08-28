using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace CRM.EndPoint.WebApi.ApplicationBase.Extensions;

public static class RepositoryExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        => services.AddRepositories();
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var repositoryTypes = assembly.GetTypes()
        .Where(type => type.IsClass && !type.IsAbstract &&
                       type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IBaseRepository<,,>)))
        .ToList();
        services
            .Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableToAny(repositoryTypes))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        return services;
    }
}
