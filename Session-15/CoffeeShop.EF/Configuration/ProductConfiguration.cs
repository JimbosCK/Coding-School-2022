﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeeShop.Model;


namespace CoffeeShop.EF.Configuration {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.ToTable("Products");

            builder.HasKey(prod => prod.ID);

            builder.Property(prod => prod.Code).HasMaxLength(20);
            builder.Property(prod => prod.Description).HasMaxLength(30);
            builder.Property(prod => prod.ProductCategoryID);

            builder.Property(prod => prod.Price).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(prod => prod.Cost).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            
            builder.HasOne(prod => prod.ProductCategory).WithOne(prodCat => prodCat.Product).HasForeignKey<Product>(prod => prod.ID);


            builder.HasOne(product => product.TransactionLine).WithOne(transLine => transLine.Product).HasForeignKey<TransactionLine>(transactionLine => transactionLine.ID);
        }
    }
}
