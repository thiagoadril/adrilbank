using AdrilBank.Domain.Base.Events;
using AdrilBank.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AdrilBank.Infra.Data.Context
{
    public class EventStoreSqlContext: DbContext
    {
        public EventStoreSqlContext(DbContextOptions<EventStoreSqlContext> options)
            : base(options)
        {
        }

        public DbSet<StoredEvent> StoredEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
