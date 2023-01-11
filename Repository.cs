using ARIS.Entity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace ARIS.Infrastructor
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DataSource DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public Repository(DataSource dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            DbSet = DbContext.Set<T>();
        }

        IQueryable<T> IRepository<T>.GetAll()
        {
            return DbSet;
        }

        IQueryable<T> IRepository<T>.Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        T IRepository<T>.GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        async Task<T> IRepository<T>.GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        async Task IRepository<T>.UpdateAsync(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        async Task IRepository<T>.AddAsync(T entity)
        {
            DbSet.Add(entity);
            await DbContext.SaveChangesAsync();
        }
        async Task IRepository<T>.RemoveAsync(T entity)
        {
            DbSet.Attach(entity);
            DbSet.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
        T IRepository<T>.GetFirst()
        {
            return DbSet.FirstOrDefault();
        }
    }
}
