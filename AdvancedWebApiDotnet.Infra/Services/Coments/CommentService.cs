using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Service;

namespace AdvancedWebApiDotnet.Infra.Services.Coment
{
    public class CommentsService : ICommentsService
    {
        private readonly IComnentsRepository _commentRepository;

        public CommentsService(IComnentsRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Create(CommentsModel model)
        {
            _commentRepository.Create(model);
        }

        public List<CommentsModel> GetAll()
        {
            return _commentRepository.GetAll();
        }
    }
}
