
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        private readonly ApplicationContext context;
        public CustomerRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(Customer entity)
        {
            context.Customers.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Customers.Remove(dbProd);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(Guid id)
        {
            return await context.Customers.SingleOrDefaultAsync(customer => customer.ID == id);
        }

        public async Task UpdateAsync(Guid id, Customer entity)
        {
            var dbProd = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbProd.Name = entity.Name;
            dbProd.Surname = entity.Surname;
            dbProd.CardNumber = entity.CardNumber;

            await context.SaveChangesAsync();

        }
    }
}
