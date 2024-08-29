using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserLogins.Entities;
using CRM.EndPoint.WebApi.Business.UserLogins.Models;
using CRM.EndPoint.WebApi.Business.UserLogins.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.UserLogins.Services;

public class UserLoginService :
    BaseRepository<UserLoginEntity, DatabaseContext, long, UserLoginDTO>,
    IUserLoginService
{
    public UserLoginService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


