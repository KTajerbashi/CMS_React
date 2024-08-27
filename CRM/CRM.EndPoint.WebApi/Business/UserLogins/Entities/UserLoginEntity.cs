using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.UserLogins.Entities;

public class UserLoginEntity : IdentityUserLogin<long>, IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
