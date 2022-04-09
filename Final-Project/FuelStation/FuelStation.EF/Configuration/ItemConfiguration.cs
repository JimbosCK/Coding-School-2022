
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Context
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");

            builder.HasKey(item => item.ID);

            builder.Property(item => item.Code).HasMaxLength(6);
            builder.Property(item => item.Description).HasMaxLength(30);
            builder.Property(item => item.ItemType).HasConversion(itemType => itemType.ToString(), itemType => (ItemTypeEnum)Enum.Parse(typeof(ItemTypeEnum), itemType)).HasMaxLength(20);
            builder.Property(item => item.Price).HasPrecision(7,2);
            builder.Property(item => item.Cost).HasPrecision(7, 2);

            builder.HasIndex(item => item.Code).IsUnique();


            builder.HasMany(item => item.TransactionLines).WithOne(transactionLine => transactionLine.Item).HasForeignKey(transactionLine => transactionLine.ItemID);

        }
    }
}
