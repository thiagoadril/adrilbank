using AdrilBank.Domain.Models;

namespace AdrilBank.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        public Task<bool> SaveChangesAsync();
    }
}
