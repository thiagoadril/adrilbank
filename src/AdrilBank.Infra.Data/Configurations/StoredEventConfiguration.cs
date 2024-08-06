using AdrilBank.Domain.Base.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdrilBank.Infra.Data.Configurations
{
    public class StoredEventConfiguration : IEntityTypeConfiguration<StoredEvent>
    {
        public void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.Property(c => c.CreatedAt)
                .IsUnicode(false);

            builder.Property(c => c.Action)
                .IsUnicode(false);
        }
    }
}
