﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoffeeShop.Model;

namespace CoffeeShop.EF.Configuration {
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employees");

            builder.HasKey(emp => emp.ID);
            
            builder.Property(emp => emp.Name).HasMaxLength(20);
            builder.Property(emp => emp.Surname).HasMaxLength(20);
            builder.Property(emp => emp.EmployeeType).HasMaxLength(20);
            builder.Property(emp => emp.SalaryPerMonth).HasColumnType("Decimal(6,2)");

        }
    }
}
