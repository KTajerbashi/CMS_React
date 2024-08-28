using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserTokens.Entities;
using CRM.EndPoint.WebApi.Business.UserTokens.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserTokens.Services;

public class UserTokenService :
    BaseRepository<UserTokenEntity, DatabaseContext, long>,
    IUserTokenService
{
    public UserTokenService(DatabaseContext context) : base(context) { }
}


