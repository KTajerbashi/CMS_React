using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserRoles.Entities;
using CRM.EndPoint.WebApi.Business.UserRoles.Models;
using CRM.EndPoint.WebApi.Business.UserRoles.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.UserRoles.Services;

public class UserRoleService :
    BaseRepository<UserRoleEntity, DatabaseContext, long, UserRoleDTO>,
    IUserRoleService
{
    public UserRoleService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


