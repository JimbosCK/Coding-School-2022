
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Context
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(20);
            builder.Property(employee => employee.Surname).HasMaxLength(20);
            builder.Property(employee => employee.Username).HasMaxLength(20);
            builder.Property(employee => employee.Password).HasMaxLength(256);
            builder.Property(employee => employee.EmployeeType).HasConversion(employeeType => employeeType.ToString(), employeeType => (EmployeeTypeEnum)Enum.Parse(typeof(EmployeeTypeEnum), employeeType)).HasMaxLength(20);
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.Property(employee => employee.HireDateEnd); //not required
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(7,2);

            builder.HasIndex(employee => employee.Username).IsUnique();

            builder.Ignore(employee => employee.FullName);

            builder.HasMany(employee => employee.Transactions).WithOne(transaction => transaction.Employee).HasForeignKey(transaction => transaction.EmployeeID);

        }
    }
}
