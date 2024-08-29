using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserClaims.Entities;
using CRM.EndPoint.WebApi.Business.UserClaims.Models;
using CRM.EndPoint.WebApi.Business.UserClaims.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;
using CRM.EndPoint.WebApi.Providers.MapperProvider.Abstraction;

namespace CRM.EndPoint.WebApi.Business.UserClaims.Services;

public class UserClaimService :
    BaseRepository<UserClaimEntity, DatabaseContext, int, UserClaimDTO>,
    IUserClaimService
{
    public UserClaimService(DatabaseContext context, IMapperAdapter mapperAdapter) : base(context, mapperAdapter)
    {
    }
}


