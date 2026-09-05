using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Comments.Service
{
    public interface ICommentsService
    {
        IList<CommentsModel> GetAll();

        void Create(CommentsModel model);
    }
}
