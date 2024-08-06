using AdrilBank.Domain.Interfaces;
using AdrilBank.Infra.Data.Context;

namespace AdrilBank.Infra.Data.UoW;

public class UnitOfWork(AdrilBankContext context) : IUnitOfWork
{
    private readonly AdrilBankContext _context = context;

    public async Task<bool> CommitAsync() => await (_context.SaveChangesAsync()) > 0;

    public void Dispose() => _context.Dispose();
}
