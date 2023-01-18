
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Context
{
    public class FuelStationShopConfiguration : IEntityTypeConfiguration<FuelStationShop>
    {
        public void Configure(EntityTypeBuilder<FuelStationShop> builder)
        {
            builder.ToTable("FuelStationShop");

            builder.HasKey(fuelStation => fuelStation.ID);

            builder.Property(fuelStation => fuelStation.MonthlyRent).HasPrecision(7, 2);
           
        }
    }
}
