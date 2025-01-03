using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace React.DomainLibrary.Identity;

[Table("Users", Schema = "Identity")]
public class UserLoginEntity : IdentityUserLogin<int>
{
}
