using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Service;

namespace AdvancedWebApiDotnet.Infra.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IComnentsRepository _comnentsRepository;
        public PostService(IPostRepository postRepository,
            IComnentsRepository comnentsRepository)
        {
            _postRepository = postRepository;
            _comnentsRepository = comnentsRepository;
        }

        public void Create(PostModel model)
        {
            _postRepository.Add(model);
        }

        public IList<PostModel> GetAll()
        {
            var includes = new List<string>()
            {
                "Persona",
                "Comments",
                "Comments.People"
            };

            return _postRepository.GetAll(includes);
        }

        public IList<CommentsModel> GetCommentsByPostId(Guid id)
        {
            return _comnentsRepository.GetAll(x => x.PostId == id);
        }
    }
}
