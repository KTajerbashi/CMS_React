using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.RoleClaims.Entities;
using CRM.EndPoint.WebApi.Business.RoleClaims.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.RoleClaims.Services;

public class RoleClaimService :
    BaseRepository<RoleClaimEntity, DatabaseContext, int>,
    IRoleClaimService
{
    public RoleClaimService(DatabaseContext context) : base(context) { }
}


