using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.RoleClaims.Entities;
using CRM.EndPoint.WebApi.Business.RoleClaims.Models;
using CRM.EndPoint.WebApi.Business.RoleClaims.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.RoleClaims.Services;

public class RoleClaimService :
    BaseRepository<RoleClaimEntity, DatabaseContext, int, RoleClaimDTO>,
    IRoleClaimService
{
    public RoleClaimService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


