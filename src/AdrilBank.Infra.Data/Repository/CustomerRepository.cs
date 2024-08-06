using AdrilBank.Domain.Interfaces;
using AdrilBank.Domain.Interfaces.Customers;
using AdrilBank.Domain.Models;
using AdrilBank.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AdrilBank.Infra.Data.Repository;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    protected readonly AdrilBankContext Db;
    protected readonly DbSet<Customer> DbSet;

    public CustomerRepository(AdrilBankContext context) : base(context)
    {
        Db = context;
        DbSet = Db.Set<Customer>();
    }

    public async Task<Customer> GetByEmailAsync(string email)
        => await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
}
