using AdvancedWebApiDotnet.Domain.Entities.Coment.Model;
using AdvancedWebApiDotnet.Domain.Entities.Coment.Repository;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedWebApiDotnet.Infra.Repositories.Coment
{

    public class CommentRepository : IComentRepository
    {
        private SqlServerContext _sqlServerContext;

        public CommentRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Create(ComentModel model)
        {
            _sqlServerContext.Coments.Add(model);
            _sqlServerContext.SaveChanges();
        }

        public List<ComentModel> GetAll()
        {
            return _sqlServerContext.Coments
                .Include(x => x.Post)
                .Include(x => x.People)
                .ToList();
        }
    }
}
