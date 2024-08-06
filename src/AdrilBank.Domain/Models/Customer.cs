using AdrilBank.Domain.Base.Models;

namespace AdrilBank.Domain.Models;

public class Customer : EntityAudit
{
    //EF Constructor
    protected Customer() { }

    public Customer(Guid id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
}