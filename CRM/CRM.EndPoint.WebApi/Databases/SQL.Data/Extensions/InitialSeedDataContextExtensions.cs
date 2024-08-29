using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Business.Users.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.Databases.SQL.Data.Extensions;

public static class InitialSeedDataContextExtensions
{
    public static ModelBuilder InitialSeedData(this ModelBuilder builder)
    {
        var HasherPassword = new PasswordHasher<UserEntity>();

        var AdminRole = new RoleEntity();
        var UserRole = new RoleEntity();

        var Admin = new UserEntity();
        var User = new UserEntity();

        HasherPassword.HashPassword(Admin,"Admin123!");
        HasherPassword.HashPassword(User, "User123!");

        return builder;
    }
}
