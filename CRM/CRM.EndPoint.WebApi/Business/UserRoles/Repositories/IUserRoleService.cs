using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.UserRoles.Entities;
using CRM.EndPoint.WebApi.Business.UserRoles.Models;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.UserRoles.Repositories;

public interface IUserRoleService : IBaseRepository<UserRoleEntity, DatabaseContext, long, UserRoleDTO> { }
