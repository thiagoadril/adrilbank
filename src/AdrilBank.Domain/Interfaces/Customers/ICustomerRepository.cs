using AdrilBank.Domain.Models;

namespace AdrilBank.Domain.Interfaces.Customers;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<Customer> GetByEmailAsync(string email);
}
