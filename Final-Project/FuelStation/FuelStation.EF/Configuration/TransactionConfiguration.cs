
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Context
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);

            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.PaymentMethod).HasConversion(paymentMenthod => paymentMenthod.ToString(), paymentMenthod => (PaymentMethodEnum)Enum.Parse(typeof(PaymentMethodEnum), paymentMenthod)).HasMaxLength(20);
            builder.Property(transaction => transaction.TotalValue).HasPrecision(7, 2);

            //builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey(transactionLine => transactionLine.TransactionID);
            builder.HasMany(transaction => transaction.TransactionLines);

            // builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.Transactions).HasForeignKey(transaction => transaction.EmployeeID);
            // builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID);

        }
    }
}
