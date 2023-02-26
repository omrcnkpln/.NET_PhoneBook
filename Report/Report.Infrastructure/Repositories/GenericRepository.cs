using Microsoft.EntityFrameworkCore;
using Report.Core.Entity;
using Report.Core.Repositories;

namespace Report.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        internal DbContext _context;
        internal DbSet<T> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> AllAsync()
        {
            return await _entities.ToListAsync();
        }
    }
}
