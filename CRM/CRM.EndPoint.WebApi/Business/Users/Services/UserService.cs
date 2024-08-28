using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.Users.Entities;
using CRM.EndPoint.WebApi.Business.Users.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.Users.Services;

public class UserService :
    BaseRepository<UserEntity, DatabaseContext, long>,
    IUserService
{
    public UserService(DatabaseContext context) : base(context) { }
}


