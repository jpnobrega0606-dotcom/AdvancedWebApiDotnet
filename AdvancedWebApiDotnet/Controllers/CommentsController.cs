using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedWebApiDotnet.Controllers
{
    [ApiController]
    [Route("comments")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var posts = _commentsService.GetAll();

                return Ok(posts);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CommentsModel model)
        {
            _commentsService.Create(model);

            return Ok();
        }
    }
}
