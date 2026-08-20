using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Service;
using AdvancedWebApiDotnet.Infra.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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

        }
        [HttpPost]
        public IActionResult Create([FromBody] PeopleModel people)

        {
            try
            {
                _peopleService.Create(people);

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] PeopleModel people)
        {

            try
            {
                _peopleService.Update(people);

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }


        [HttpDelete("{Id}")]
        public IActionResult Delete(Guid Id)
        {
            try
            {

                _peopleService.Delete(Id);
                return StatusCode(200);
            }

            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }

        }
        
    }
}
