using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.UserClaims.Entities;
using CRM.EndPoint.WebApi.Business.UserClaims.Models;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserClaims.Repositories;

public interface IUserClaimService : IBaseRepository<UserClaimEntity, DatabaseContext, int, UserClaimDTO> { }
