using ClothingManager.Application.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingManager.Application.Database.Mappings
{
    internal sealed class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Name).IsRequired();
            builder.Property(customer => customer.Initials);
            builder.Property(customer => customer.Identifier).IsRequired();
        }
    }
}
