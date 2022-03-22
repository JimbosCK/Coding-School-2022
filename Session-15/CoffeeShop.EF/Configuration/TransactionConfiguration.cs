using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeeShop.Model;


namespace CoffeeShop.EF.Configuration {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);

            builder.Property(transaction => transaction.Date);
            // TODO: add foreign keys
            builder.Property(transaction => transaction.EmployeeID);
            builder.Property(transaction => transaction.CustomerID);

            // TODO: What happens with lists 

            builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transaction => transaction.TotalCost).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

            builder.Property(transaction => transaction.PaymentMethod);


        }

    }
}
