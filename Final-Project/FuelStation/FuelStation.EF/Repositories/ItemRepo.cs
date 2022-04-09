
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        private readonly ApplicationContext context;
        public ItemRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(Item entity)
        {
            context.Items.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.Items.SingleOrDefault(item => item.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Items.Remove(dbProd);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id)
        {
            return await context.Items.SingleOrDefaultAsync(item => item.ID == id);
        }

        public async Task UpdateAsync(Guid id, Item entity)
        {
            var dbProd = context.Items.SingleOrDefault(item => item.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbProd.Code = entity.Code;
            dbProd.Description = entity.Description;
            dbProd.ItemType = entity.ItemType;
            dbProd.Price = entity.Price;
            dbProd.Cost = entity.Cost;
        }
    }
}
