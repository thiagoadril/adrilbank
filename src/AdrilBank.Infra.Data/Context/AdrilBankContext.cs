using AdrilBank.Domain.Base.Events;
using AdrilBank.Domain.Models;
using AdrilBank.Infra.Data.Configurations;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace AdrilBank.Infra.Data.Context
{
    public sealed class AdrilBankContext : DbContext
    {
        public AdrilBankContext(DbContextOptions<AdrilBankContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public Task<bool> CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
