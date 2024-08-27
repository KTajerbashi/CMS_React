using CRM.EndPoint.WebApi.ApplicationBase.Entity;
using Microsoft.AspNetCore.Identity;

namespace CRM.EndPoint.WebApi.Business.UserClaims.Entities;

public class UserClaimEntity : IdentityUserClaim<long>,IEntity
{
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
}
