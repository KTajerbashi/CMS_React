using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.Roles.Entities;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.Roles.Repositories;

public interface IRoleService : IBaseRepository<RoleEntity, DatabaseContext, long> { }
