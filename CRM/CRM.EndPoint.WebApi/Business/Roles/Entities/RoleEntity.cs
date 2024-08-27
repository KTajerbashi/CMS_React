using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.Roles.Entities;

public class RoleEntity : IdentityRole<long> ,IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
