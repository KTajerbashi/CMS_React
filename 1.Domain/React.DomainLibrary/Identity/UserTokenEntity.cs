using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace React.DomainLibrary.Identity;

[Table("UserTokens", Schema = "Identity")]
public class UserTokenEntity : IdentityUserToken<int>
{
}
