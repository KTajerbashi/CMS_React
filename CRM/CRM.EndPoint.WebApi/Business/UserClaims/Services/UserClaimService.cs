using CRM.EndPoint.WebApi.ApplicationBase.Service;
using CRM.EndPoint.WebApi.Business.UserClaims.Entities;
using CRM.EndPoint.WebApi.Business.UserClaims.Repositories;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserClaims.Services;

public class UserClaimService :
    BaseRepository<UserClaimEntity, DatabaseContext, int>,
    IUserClaimService
{
    public UserClaimService(DatabaseContext context) : base(context) { }
}


