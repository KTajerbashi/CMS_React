using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.UserTokens.Entities;
using CRM.EndPoint.WebApi.Business.UserTokens.Models;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserTokens.Repositories;

public interface IUserTokenService : IBaseRepository<UserTokenEntity, DatabaseContext, long, UserTokenDTO> { }
