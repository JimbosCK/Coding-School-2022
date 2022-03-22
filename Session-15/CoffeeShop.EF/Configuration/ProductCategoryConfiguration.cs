using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeeShop.Model;

namespace CoffeeShop.EF.Configuration {
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory> {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) {
            builder.ToTable("ProductCategories");

            builder.HasKey(pCat => pCat.ID);

            builder.Property(pCat => pCat.Code).HasMaxLength(10);
            builder.Property(pCat => pCat.Description).HasMaxLength(30);
            builder.Property(pCat => pCat.ProductType);

        }
    }
}
