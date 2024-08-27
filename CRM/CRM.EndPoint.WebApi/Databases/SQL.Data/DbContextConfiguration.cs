using CRM.EndPoint.WebApi.Business.RoleClaims.Entities;
using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Business.UserClaims.Entities;
using CRM.EndPoint.WebApi.Business.UserLogins.Entities;
using CRM.EndPoint.WebApi.Business.UserRoles.Entities;
using CRM.EndPoint.WebApi.Business.Users.Entities;
using CRM.EndPoint.WebApi.Business.UserTokens.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM.EndPoint.WebApi.Databases.SQL.Data;

public static class DbContextConfiguration
{
    public static ModelBuilder AddBuilderConfiguration(this ModelBuilder builder)
    {
        builder.Entity<UserEntity>().ToTable("Users", "Security");
        builder.Entity<RoleEntity>().ToTable("Roles", "Security");
        builder.Entity<RoleClaimEntity>().ToTable("RoleClaims", "Security");
        builder.Entity<UserClaimEntity>().ToTable("UserClaims", "Security");
        builder.Entity<UserLoginEntity>().ToTable("UserLogins", "Security");
        builder.Entity<UserRoleEntity>().ToTable("UserRoles", "Security");
        builder.Entity<UserTokenEntity>().ToTable("UserTokens", "Security");
        return builder;
    }
}