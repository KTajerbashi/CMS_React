using CRM.EndPoint.WebApi.ApplicationBase.BaseControllers;
using CRM.EndPoint.WebApi.Business.Users.Repositories;
using CRM.EndPoint.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRM.EndPoint.WebApi.Controllers;

public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserService _userService;
    public HomeController(ILogger<HomeController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var data = await _userService.GetAsync();
        return View();
    }

    [Route("Privacy")]
    public async Task<IActionResult> Privacy()
    {
        var data = await _userService.GetAsync();
        return View();
    }

    [Route("Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> Error()
    {
        var data = await _userService.GetAsync();
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
