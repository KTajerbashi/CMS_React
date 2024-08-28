using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Business.Roles.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.Roles.Services;

public class RoleService :
    BaseRepository<RoleEntity, DatabaseContext, long>,
    IRoleService
{
    public RoleService(DatabaseContext context) : base(context) { }
}


