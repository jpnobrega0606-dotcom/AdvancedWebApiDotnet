using AdvancedWebApiDotnet.Domain.Entities.Common.Model;
using AdvancedWebApiDotnet.Domain.Entities.Common.Repository;
using AdvancedWebApiDotnet.Infra.Storage.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdvancedWebApiDotnet.Infra.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityModel
    {
        protected SqlServerContext _sqlServerContext;

        public BaseRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public virtual void Add(T entity)
        {
            _sqlServerContext.Set<T>().Add(entity);
            _sqlServerContext.SaveChanges();
        }

        public virtual void AddRange(IList<T> entities)
        {
            _sqlServerContext.Set<T>().AddRange(entities);
            _sqlServerContext.SaveChanges();
        }

        public virtual void Delete(Guid id)
        {
            var query = _sqlServerContext.Set<T>().First(x => x.Id == id);

            if (query != null)
            {
                _sqlServerContext.Set<T>().Remove(query);
                _sqlServerContext.SaveChanges();
            }
        }

        public virtual IList<T> GetAll()
        {
            var query = _sqlServerContext.Set<T>().ToList();

            return query;
        }

        public virtual IList<T> GetAll(IList<string> includes)
        {
            var query = _sqlServerContext
               .Set<T>()
               .AsNoTracking();

            if (includes?.Count > 0)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }

            return query.ToList();
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> clauses)
        {
            var query = _sqlServerContext
                .Set<T>()
                .AsNoTracking()
                .Where(clauses).ToList();

            return query;
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> clauses, IList<string> includes)
        {
            var query = _sqlServerContext
                .Set<T>()
                .AsNoTracking()
                .Where(clauses);

            if (includes?.Count > 0)
            {
                foreach (var item in includes)
                {
                    query.Include(item);
                }
            }

            return query.ToList();
        }

        public virtual T GetById(Guid id)
        {
            var query = _sqlServerContext.Set<T>().First(x => x.Id == id);

            return query;
        }

        public virtual void Update(T entity)
        {
            _sqlServerContext.Entry(entity).State = EntityState.Modified;
            _sqlServerContext.Set<T>().Update(entity);
            _sqlServerContext.SaveChanges();
        }
    }
}
