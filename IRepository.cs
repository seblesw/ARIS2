using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace ARIS.Entity
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(Guid id);
        Task UpdateAsync(T entity);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        T GetFirst();
    }
}
