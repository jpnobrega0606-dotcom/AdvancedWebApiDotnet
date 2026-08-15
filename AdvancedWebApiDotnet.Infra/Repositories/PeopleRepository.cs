using AdvancedWebApiDotnet.Domain.Entities.People.Model;
using AdvancedWebApiDotnet.Domain.Entities.People.Repository;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Infra.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private SqlServerContext _sqlServerContext;

        public PeopleRepository(SqlServerContext context) 
        {
            _sqlServerContext = context;
        }

        public IList<PeopleModel> GetAll()
        {
            return _sqlServerContext.People.ToList();
        }
    }
}
