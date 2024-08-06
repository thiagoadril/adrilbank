using AdrilBank.Domain.Interfaces;
using AdrilBank.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AdrilBank.Infra.Data.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AdrilBankContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(AdrilBankContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbSet.ToListAsync();
    public virtual async Task<TEntity> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);
    public virtual void Add(TEntity entity) => _dbSet.Add(entity);
    public virtual void Remove(TEntity entity) => _dbSet.Remove(entity);
    public virtual void Update(TEntity entity) => _dbSet.Update(entity);

    public async Task<bool> SaveChangesAsync() => (await _dbContext.SaveChangesAsync()) > 0;
    public void Dispose() => _dbContext.Dispose();

}
