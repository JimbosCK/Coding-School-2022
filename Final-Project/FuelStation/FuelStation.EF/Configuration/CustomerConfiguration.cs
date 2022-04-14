
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Context
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Name).HasMaxLength(20);
            builder.Property(customer => customer.Surname).HasMaxLength(20);
            builder.Property(customer => customer.CardNumber).HasMaxLength(20);
            
            builder.HasIndex(customer => customer.CardNumber).IsUnique();

            builder.Ignore(customer => customer.FullName);

           // builder.HasMany(customer => customer.Transactions).WithOne(transaction => transaction.Customer).HasForeignKey(transaction => transaction.CustomerID);

        }
    }
}
