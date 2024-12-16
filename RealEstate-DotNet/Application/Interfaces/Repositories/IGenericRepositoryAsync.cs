using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        IQueryable<T> GetTableNoTracking();
        IQueryable<T> GetTableAsTracking();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(ICollection<T> entities);


        Task SaveChangesAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitAsync();
        Task RollBackAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        Task<List<T>> AddRangeListAsync(List<T> entities);
    }
}
