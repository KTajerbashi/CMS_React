using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserRoles.Entities;
using CRM.EndPoint.WebApi.Business.UserRoles.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserRoles.Services;

public class UserRoleService :
    BaseRepository<UserRoleEntity, DatabaseContext, long>,
    IUserRoleService
{
    public UserRoleService(DatabaseContext context) : base(context) { }
}


