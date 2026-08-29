using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AdvancedWebApiDotnet.Infra.Repositories.Coments
{

    public class CommentsRepository : IComnentsRepository
    {
        private SqlServerContext _sqlServerContext;

        public CommentsRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Create(CommentsModel model)
        {
            _sqlServerContext.Comments.Add(model);
            _sqlServerContext.SaveChanges();
        }

        public List<CommentsModel> GetAll()
        {
            return _sqlServerContext.Comments
                .Include(x => x.Post)
                .Include(x => x.People)
                .ToList();
        }
    }
}
