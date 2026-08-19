using AdvancedWebApiDotnet.Domain.Entities.People.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedWebApiDotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var people = _peopleService.GetAllPeople();

                return StatusCode(200, people);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }



            [HttpPost]
            public IActionResult Create([FromBody] PeopleModel people)
            {
                return StatusCode(_peopleService.Create(people));
            }

        }
    }
}
