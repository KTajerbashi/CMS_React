using CRM.EndPoint.WebApi.ApplicationBase.Database;
using CRM.EndPoint.WebApi.Databases.SQL.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.Databases.SQL.Data;

public class DatabaseContext : BaseDatabaseContext
{
    protected DatabaseContext()
    {

    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.AddBuilderConfiguration();
        builder.InitialSeedData();
    }
}
