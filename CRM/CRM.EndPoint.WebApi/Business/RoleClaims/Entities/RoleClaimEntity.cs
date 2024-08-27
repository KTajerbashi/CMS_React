using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.RoleClaims.Entities;

public class RoleClaimEntity : IdentityRoleClaim<long>,IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
