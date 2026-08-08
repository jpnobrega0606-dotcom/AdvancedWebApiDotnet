using AdvancedWebApiDotnet.Domain.Entities.People;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvancedWebApiDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly SqlServerContext _context;

        public PeopleController(SqlServerContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index() {

            return Ok(_context.People.Where(p => p.FirstName == "teste"));
        }
    }
}
