using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.UserRoles.Entities;

public class UserRoleEntity : IdentityUserRole<long>, IEntity<long>
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public long Id { get; set; }
    public Guid Key { get; set; }
}
