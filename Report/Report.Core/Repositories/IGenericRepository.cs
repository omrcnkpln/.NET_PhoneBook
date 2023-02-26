using Report.Core.Entity;

namespace Report.Core.Repositories
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<IEnumerable<T>> AllAsync();
        //Task<T> GetById(int id);
        Task AddAsync(T entity);
        //Task Delete(int id);
        //void Update(T entity);
    }
}
