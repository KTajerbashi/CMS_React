using CRM.EndPoint.WebApi.Business.RoleClaims.Entities;
using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Business.UserClaims.Entities;
using CRM.EndPoint.WebApi.Business.UserLogins.Entities;
using CRM.EndPoint.WebApi.Business.UserRoles.Entities;
using CRM.EndPoint.WebApi.Business.Users.Entities;
using CRM.EndPoint.WebApi.Business.UserTokens.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace CRM.EndPoint.WebApi.ApplicationBase.Database;

public abstract class BaseDatabaseContext : IdentityDbContext<UserEntity, RoleEntity, long, UserClaimEntity, UserRoleEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>
{
    protected IDbContextTransaction _transaction;
    protected BaseDatabaseContext(){}
    protected BaseDatabaseContext(DbContextOptions options):base(options){}


}
