using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Repository;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AdvancedWebApiDotnet.Infra.Repositories.Posts
{
    public class PostRepository : IPostRepository
    {
        private SqlServerContext _sqlServerContext;

        public PostRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Create(PostModel model)
        {
            _sqlServerContext.Posts.Add(model);
            _sqlServerContext.SaveChanges();
        }

        public IList<PostModel> GetAll()
        {
            return _sqlServerContext.Posts.Include(x => x.Persona).ToList();
        }
    }
}
