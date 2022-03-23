using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using CoffeeShop.Model;


namespace CoffeeShop.EF.Configuration {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Customers");

            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Code).HasMaxLength(10);
            builder.Property(customer => customer.Description).HasMaxLength(30);


            builder.HasOne(customer => customer.Transaction).WithOne(transaction => transaction.Customer).HasForeignKey<Transaction>(transaction => transaction.ID);
        }
    }
}
