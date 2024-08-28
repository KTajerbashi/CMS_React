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
    [HttpGet]
    public async Task<IActionResult> Privacy()
    {
        var data = await _userService.GetAsync();
        return View();
    }

    [Route("Error")]
    [HttpGet]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> Error()
    {
        var data = await _userService.GetAsync();
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


public class AccountController : AuthorizationController
{
    // GET: api/Employee
    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        return GetEmployees();
    }
    // GET: api/Employee/5
    [HttpGet("{id}", Name = "Get")]
    public Employee Get(int id)
    {
        return GetEmployees().Find(e => e.Id == id);
    }
    // POST: api/Employee
    [HttpPost]
    [Produces("application/json")]
    public Employee Post([FromBody] Employee employee)
    {
        // Logic to create new Employee
        return new Employee();
    }
    // PUT: api/Employee/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Employee employee)
    {
        // Logic to update an Employee
    }
    // DELETE: api/Employee/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
    private List<Employee> GetEmployees()
    {
        return new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
    }
}
public class Employee
{
    public int Id { get; set; }
    public string FirstName{ get; set; }
    public string LastName { get; set; }
    public string EmailId { get; set; }
}