using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.UserLogins.Entities;

public class UserLoginEntity : IdentityUserLogin<long>, IEntity<long>
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public long Id { get; set; }
    public Guid Key { get; set; }
}
