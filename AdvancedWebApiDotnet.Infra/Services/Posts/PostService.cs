using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Service;

namespace AdvancedWebApiDotnet.Infra.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void Create(PostModel model)
        {
            _postRepository.Create(model);
        }

        public IList<PostModel> GetAll()
        {
            return _postRepository.GetAll();
        }
    }
}
