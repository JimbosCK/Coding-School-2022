using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeeShop.Model;


namespace CoffeeShop.EF.Configuration {
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("Products");

            builder.HasKey(transLine => transLine.ID);
            
            builder.Property(transLine => transLine.TransactionID);

            builder.Property(transLine => transLine.Quantity);
            builder.Property(transLine => transLine.Price).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

            builder.Property(transLine => transLine.DiscountPerCent).HasMaxLength(30);
            
            builder.Property(transLine => transLine.Discount).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transLine => transLine.DisplayPrice).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transLine => transLine.TotalPrice).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transLine => transLine.TotalCost).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

            //Constraints

            builder.HasOne(transLine => transLine.Product).WithOne(product => product.TransactionLine).HasForeignKey<TransactionLine>(transactionLine => transactionLine.ID);

            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transactionLine => transactionLine.ID);

        }
    }
}
