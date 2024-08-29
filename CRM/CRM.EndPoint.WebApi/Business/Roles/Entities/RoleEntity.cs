using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.Roles.Entities;

public class RoleEntity : IdentityRole<long>, IEntity<long>
{
    public string Title { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public Guid Key { get; set; }
    public RoleEntity()
    {
        
    }
    public RoleEntity(string name,string title)
    {
        Title = title;
        Name = name;
    }
}
