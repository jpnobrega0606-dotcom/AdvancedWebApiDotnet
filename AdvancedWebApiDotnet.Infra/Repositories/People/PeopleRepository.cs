using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Repository;
using AdvancedWebApiDotnet.Infra.Repositories.Common;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;

namespace AdvancedWebApiDotnet.Infra.Repositories.People
{
    public class PeopleRepository : BaseRepository<PeopleModel>, IPeopleRepository
    {
        public PeopleRepository(SqlServerContext context) : base(context)
        {
            _sqlServerContext = context;
        }
    }
}
