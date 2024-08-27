using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.UserRoles.Entities;

public class UserRoleEntity : IdentityUserRole<long>, IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
