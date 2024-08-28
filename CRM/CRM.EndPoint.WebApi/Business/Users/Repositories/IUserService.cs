using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.Users.Entities;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.Users.Repositories;

public interface IUserService : IBaseRepository<UserEntity, DatabaseContext, long> { }
