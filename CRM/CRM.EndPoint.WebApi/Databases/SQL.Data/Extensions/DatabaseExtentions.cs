using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.Databases.SQL.Data.Extensions;

public static class DatabaseExtentions
{
    public static IServiceCollection AddDatabaseContext(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<DatabaseContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}
