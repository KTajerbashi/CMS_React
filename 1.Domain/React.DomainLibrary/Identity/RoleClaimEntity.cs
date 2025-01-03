using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace React.DomainLibrary.Identity;

[Table("RoleClaims", Schema = "Identity")]
public class RoleClaimEntity : IdentityRoleClaim<int>
{
}
