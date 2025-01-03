using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace React.DomainLibrary.Identity;

[Table("Users", Schema = "Identity")]
public class UserEntity : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
}
