using AdvancedWebApiDotnet.Domain.Entities.Posts.Model;
using AdvancedWebApiDotnet.Domain.Entities.Posts.Repository;
using AdvancedWebApiDotnet.Infra.Repositories.Common;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;

namespace AdvancedWebApiDotnet.Infra.Repositories.Posts
{
    public class PostRepository : BaseRepository<PostModel>, IPostRepository
    {
        public PostRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }
    }
}
