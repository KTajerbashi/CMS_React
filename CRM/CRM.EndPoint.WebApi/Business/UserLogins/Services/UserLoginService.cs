using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserLogins.Entities;
using CRM.EndPoint.WebApi.Business.UserLogins.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserLogins.Services;

public class UserLoginService :
    BaseRepository<UserLoginEntity, DatabaseContext, long>,
    IUserLoginService
{
    public UserLoginService(DatabaseContext context) : base(context) { }
}


