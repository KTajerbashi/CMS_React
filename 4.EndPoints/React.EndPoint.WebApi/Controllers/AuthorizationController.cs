using Microsoft.AspNetCore.Mvc;
using React.EndPoint.WebApi.Controllers.Bases;

namespace React.EndPoint.WebApi.Controllers;

public class AuthorizationController : BaseApiController
{
    // Login action simplified without needing async when no I/O operation is involved
    [HttpPost("Register")]
    public IActionResult Register()
    {
        return Return("Register");
    }

    [HttpGet("RemoveAccount")]
    public IActionResult RemoveAccount()
    {
        return Return("RemoveAccount");
    }
}
