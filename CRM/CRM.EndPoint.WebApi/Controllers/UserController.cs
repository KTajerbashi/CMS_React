using CRM.EndPoint.WebApi.ApplicationBase.BaseControllers;
using CRM.EndPoint.WebApi.Business.Users.Models;
using CRM.EndPoint.WebApi.Business.Users.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRM.EndPoint.WebApi.Controllers;

public class UserController : AuthorizationController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Insert(UserDTO model)
    {
        await _userService.InsertAsync(model);
        await _userService.SaveChangeAsync();
        return Ok(model);
    }

    [HttpPut]
    public async Task<IActionResult> Update(long id, UserDTO model)
    {
        model.Id = id;
        var result =  await _userService.InsertAsync(model);
        return Ok(result);
    }


    [HttpDelete]
    public async Task<IActionResult> Delete(Guid key)
    {
        await _userService.DeleteAsync(key);
        return Ok();
    }


    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _userService.GetAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        var result = await _userService.GetAsync();
        return Ok(result);
    }
}
