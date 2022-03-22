
using CoffeeShop.EF.Configuration;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EF.Context {
    public class ApplicationContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = DbCoffeeShop; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
