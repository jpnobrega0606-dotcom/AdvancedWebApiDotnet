using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Service;
using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;

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
            _commentRepository.Add(model);
        }

        public IList<CommentsModel> GetAll()
        {
            var include = new List<string>()
            {
                typeof(PostModel).FullName,
                typeof(PeopleModel).FullName,
            };

            return _commentRepository.GetAll(include);
        }
    }
}
