using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Business.Roles.Models;
using CRM.EndPoint.WebApi.Business.Roles.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.Roles.Services;

public class RoleService :
    BaseRepository<RoleEntity, DatabaseContext, long, RoleDTO>,
    IRoleService
{
    public RoleService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


