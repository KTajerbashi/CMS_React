using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.UserLogins.Entities;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserLogins.Repositories;

public interface IUserLoginService : IBaseRepository<UserLoginEntity, DatabaseContext, long> { }
