using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Domain.Entities.Comments.Model;
using AdvancedWebApiDotnet.Infra.Repositories.Common;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;

namespace AdvancedWebApiDotnet.Infra.Repositories.Coments
{
    public class CommentsRepository : BaseRepository<CommentsModel>, IComnentsRepository
    {
        public CommentsRepository(SqlServerContext sqlServerContext) : base(sqlServerContext)
        {
            {
                _sqlServerContext = sqlServerContext;
            }
        }
    }
}
