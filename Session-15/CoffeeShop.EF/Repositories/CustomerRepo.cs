using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public async Task Create(Customer entity) {
            using var context = new ApplicationContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new ApplicationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll() {
            using var context = new ApplicationContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new ApplicationContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Customer entity) {
            using var context = new ApplicationContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;

            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            foundCustomer.Transaction = entity.Transaction;

            await context.SaveChangesAsync();
        }
    }
}
