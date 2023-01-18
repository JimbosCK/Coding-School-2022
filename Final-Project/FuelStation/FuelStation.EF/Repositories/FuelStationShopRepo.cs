
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class FuelStationShopRepo : IEntityRepo<FuelStationShop>
    {
        private readonly ApplicationContext context;
        public FuelStationShopRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(FuelStationShop entity)
        {
            context.FuelStationShops.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.FuelStationShops.SingleOrDefault(fuelStationShop => fuelStationShop.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.FuelStationShops.Remove(dbProd);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FuelStationShop>> GetAllAsync()
        {
            return await context.FuelStationShops.ToListAsync();
        }

        public async Task<FuelStationShop?> GetByIdAsync(Guid id)
        {
            return await context.FuelStationShops.SingleOrDefaultAsync(fuelStationShop => fuelStationShop.ID == id);
        }

        public async Task UpdateAsync(Guid id, FuelStationShop entity)
        {
            var dbfuelStationShop = context.FuelStationShops.SingleOrDefault(fuelStationShop => fuelStationShop.ID == id);
            if (dbfuelStationShop is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            dbfuelStationShop.MonthlyRent = entity.MonthlyRent;
            
            await context.SaveChangesAsync();
        }
    }
}
