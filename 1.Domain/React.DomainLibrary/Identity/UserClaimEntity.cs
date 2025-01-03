using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace React.DomainLibrary.Identity;

[Table("UserClaims", Schema = "Identity")]
public class UserClaimEntity : IdentityUserClaim<int>
{
}
