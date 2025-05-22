using ClothingManager.Application.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingManager.Application.Database.Mappings
{
    internal sealed class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.Id);
            builder.Property(employee => employee.Name).IsRequired();
            builder.Property(employee => employee.Identifier).IsRequired();
            builder.Property(employee => employee.BirthDate).IsRequired();
        }
    }
}
