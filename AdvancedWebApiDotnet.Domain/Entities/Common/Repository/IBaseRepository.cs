using AdvancedWebApiDotnet.Domain.Entities.Common.Model;
using System.Linq.Expressions;

namespace AdvancedWebApiDotnet.Domain.Entities.Common.Repository
{
    public interface IBaseRepository<T> where T : EntityModel
    {
        void Add(T entity);
        void Delete(Guid id);
        void Update(T entity);
        T GetById(Guid id);
        void AddRange(IList<T> entities);
        IList<T> GetAll();
        IList<T> GetAll(IList<string> includes);
        IList<T> GetAll(Expression<Func<T, bool>> clauses);
        IList<T> GetAll(Expression<Func<T, bool>> clauses, IList<string> includes);
    }
}
