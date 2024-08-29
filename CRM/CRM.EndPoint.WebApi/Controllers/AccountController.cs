using CRM.EndPoint.WebApi.ApplicationBase.BaseControllers;
using Microsoft.AspNetCore.Mvc;

namespace CRM.EndPoint.WebApi.Controllers;
public class AccountController : AuthorizationController
{
    // GET: api/Account
    [HttpGet]
    public IEnumerable<Account> Get()
    {
        return GetAccounts();
    }
    // GET: api/Account/5
    [HttpGet("{id}", Name = "Get")]
    public Account Get(int id)
    {
        return GetAccounts().Find(e => e.Id == id);
    }
    // POST: api/Account
    [HttpPost]
    [Produces("application/json")]
    public Account Post([FromBody] Account Account)
    {
        // Logic to create new Account
        return new Account();
    }
    // PUT: api/Account/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Account Account)
    {
        // Logic to update an Account
    }
    // DELETE: api/Account/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
    private List<Account> GetAccounts()
    {
        return new List<Account>()
        {
            new Account()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new Account()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
    }
}
