using CRM.EndPoint.WebApi.ApplicationBase.Repository;
using CRM.EndPoint.WebApi.Business.RoleClaims.Entities;
using CRM.EndPoint.WebApi.Business.RoleClaims.Models;
using CRM.EndPoint.WebApi.Databases.SQL.Data;

namespace CRM.EndPoint.WebApi.Business.RoleClaims.Repositories;

public interface IRoleClaimService : IBaseRepository<RoleClaimEntity, DatabaseContext, int, RoleClaimDTO> { }
