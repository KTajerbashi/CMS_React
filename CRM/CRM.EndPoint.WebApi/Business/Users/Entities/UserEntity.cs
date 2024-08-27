using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.Users.Entities;

public class UserEntity : IdentityUser<long>, IEntity<long>
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public Guid Key { get; set; }
}
