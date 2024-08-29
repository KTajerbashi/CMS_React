using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserTokens.Entities;
using CRM.EndPoint.WebApi.Business.UserTokens.Models;
using CRM.EndPoint.WebApi.Business.UserTokens.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.UserTokens.Services;

public class UserTokenService :
    BaseRepository<UserTokenEntity, DatabaseContext, long, UserTokenDTO>,
    IUserTokenService
{
    public UserTokenService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


