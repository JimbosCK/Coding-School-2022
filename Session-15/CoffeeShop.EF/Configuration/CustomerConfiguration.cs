using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoffeeShop.Model;


namespace CoffeeShop.EF.Configuration {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {
            builder.ToTable("Custmoers");

            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Code).HasMaxLength(10);
            builder.Property(customer => customer.Description).HasMaxLength(30);

        }
    }
}
