using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.RoleClaims.Entities;

public class RoleClaimEntity : IdentityRoleClaim<long>, IEntity<int>
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public Guid Key { get; set; }
}
