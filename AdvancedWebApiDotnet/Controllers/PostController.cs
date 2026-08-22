using AdvancedWebApiDotnet.Domain.Entities.People.Service;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedWebApiDotnet.Controllers
{
    [ApiController]
    [Route("posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var posts = _postService.GetAll();

                return Ok(posts);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] PostModel model)
        {
            _postService.Create(model);

            return Ok();
        }
    }
}
