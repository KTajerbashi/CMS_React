using Microsoft.AspNetCore.Mvc;
using React.EndPoint.WebApi.Controllers.Bases;

namespace React.EndPoint.WebApi.Controllers;

// Concrete controller with authentication-specific behavior
public class AuthenticateController : BaseController
{
    // Login action simplified without needing async when no I/O operation is involved
    [HttpPost("Login")]
    public IActionResult Login()
    {
        return Return("Login");
    }

    [HttpGet("Signout")]
    public IActionResult Signout()
    {
        return Return("Signout");
    }
}
