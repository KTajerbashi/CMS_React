using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace React.ApplicationLibrary;

public static class DepenedencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {

        return services;
    }
}
