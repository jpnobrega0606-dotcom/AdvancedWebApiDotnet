using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Posts.Service
{
    public interface IPostService
    {
        IList<PostModel> GetAll();
        void Create(PostModel model);
        IList<CommentsModel> GetCommentsByPostId(Guid id);
    }
}
