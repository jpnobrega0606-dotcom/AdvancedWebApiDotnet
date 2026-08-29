using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;

namespace AdvancedWebApiDotnet.Domain.Entities.Coment.Repository
{
    public interface IComnentsRepository
    {
        List<CommentsModel> GetAll();

        void Create(CommentsModel model);
    }
}
