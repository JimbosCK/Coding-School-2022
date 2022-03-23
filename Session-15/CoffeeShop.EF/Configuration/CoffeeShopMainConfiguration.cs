//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using CoffeeShop.Model;

//namespace CoffeeShop.EF.Configuration {
//    internal class CoffeeShopMainConfiguration : IEntityTypeConfiguration<CoffeeShopMain> {
//        public void Configure(EntityTypeBuilder<CoffeeShopMain> builder) {
//            builder.ToTable("CoffeeShop");

//            builder.HasKey(shop => shop.ID);

//            builder.HasMany(shop => shop.Employees).WithOne(employee => employee.Shop).HasForeignKey(employee => employee.ID).OnDelete(DeleteBehavior.NoAction);
//            builder.HasMany(shop => shop.Customers).WithOne(customer => customer.Shop).HasForeignKey(customer => customer.ID).OnDelete(DeleteBehavior.NoAction);
//            builder.HasMany(shop => shop.Products).WithOne(product => product.Shop).HasForeignKey(product => product.ID).OnDelete(DeleteBehavior.NoAction);
//            builder.HasMany(shop => shop.ProductCats).WithOne(ProductCat => ProductCat.Shop).HasForeignKey(ProductCat => ProductCat.ID).OnDelete(DeleteBehavior.NoAction);
//            builder.HasMany(shop => shop.Transactions).WithOne(transaction => transaction.Shop).HasForeignKey(transaction => transaction.ID).OnDelete(DeleteBehavior.NoAction);
            
//        }
//    }
//}
