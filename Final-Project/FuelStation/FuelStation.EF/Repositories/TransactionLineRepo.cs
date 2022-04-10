
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        private readonly ApplicationContext context;
        public TransactionLineRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(TransactionLine entity)
        {
            context.TransactionLines.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.TransactionLines.Remove(dbProd);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionLine>> GetAllAsync()
        {
            return await context.TransactionLines.ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id)
        {
            return await context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.ID == id);
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity)
        {
            var dbProd = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbProd.TransactionID = entity.TransactionID;
            dbProd.ItemID = entity.ItemID;
            dbProd.Quantity = entity.Quantity;
            dbProd.ItemPrice = entity.ItemPrice;
            dbProd.NetValue = entity.NetValue;
            dbProd.DiscountPercent = entity.DiscountPercent;
            dbProd.DiscountValue = entity.DiscountValue;
            dbProd.TotalValue = entity.TotalValue;
            await context.SaveChangesAsync();

        }
    }
}
