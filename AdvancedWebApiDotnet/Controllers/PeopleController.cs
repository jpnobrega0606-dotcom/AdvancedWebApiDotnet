using AdvancedWebApiDotnet.Domain.Entities.People;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedWebApiDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index() { 
        
            using(var context = new SqlServerContext())
            {
                return Ok(context.People.Where(p => p.FirstName == "teste"));
            }
        }
    }
}
