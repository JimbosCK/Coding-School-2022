
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        private readonly ApplicationContext context;
        public TransactionRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(Transaction entity)
        {
            context.Transactions.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.Transactions.Include(transaction => transaction.TransactionLines).SingleOrDefault(transaction => transaction.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Transactions.Remove(dbProd);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await context.Transactions.Include(transaction => transaction.TransactionLines).ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id)
        {
            return await context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
        }

        public async Task UpdateAsync(Guid id, Transaction entity)
        {
            var dbProd = context.Transactions.Include(transaction => transaction.TransactionLines).SingleOrDefault(transaction => transaction.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            dbProd.Date = entity.Date;
            dbProd.EmployeeID = entity.EmployeeID;
            dbProd.CustomerID = entity.CustomerID;
            dbProd.PaymentMethod = entity.PaymentMethod;
            dbProd.TotalValue = entity.TotalValue;
            dbProd.TransactionLines = entity.TransactionLines;

            await context.SaveChangesAsync();

        }
    }
}
