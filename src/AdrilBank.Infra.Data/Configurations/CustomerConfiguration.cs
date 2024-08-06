using AdrilBank.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdrilBank.Infra.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(256)
                .IsUnicode(false)
                .IsRequired();

            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
