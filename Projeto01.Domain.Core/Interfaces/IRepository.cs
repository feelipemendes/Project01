namespace Projeto01.Domain.Core.Interfaces
{
    public interface IRepository<TEntity, TKey> : IDisposable
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync(int page, int limit);
        Task<TEntity> GetByIdAsync(TKey id);
    }
}
