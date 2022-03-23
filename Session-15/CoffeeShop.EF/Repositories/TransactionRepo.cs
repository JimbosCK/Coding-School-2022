using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CoffeeShop.EF.Context;
using CoffeeShop.Model;

namespace CoffeeShop.EF.Repositories {
    public class TransactionRepo : IEntityRepo<CoffeeShop.Model.Transaction> {
        public async Task Create(Model.Transaction entity) {
            using var context = new ApplicationContext();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new ApplicationContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            context.Transactions.Remove(foundTrans);
            await context.SaveChangesAsync();
        }

        public List<Model.Transaction> GetAll() {
            using var context = new ApplicationContext();
            return context.Transactions.ToList();
        }

        public Model.Transaction? GetById(Guid id) {
            using var context = new ApplicationContext();
            return context.Transactions.Where(trans => trans.ID == id).SingleOrDefault(); ;
        }

        public async Task Update(Guid id, Model.Transaction entity) {
            using var context = new ApplicationContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            foundTrans.Date = entity.Date;
            foundTrans.EmployeeID = entity.EmployeeID;
            foundTrans.CustomerID = entity.CustomerID;
            foundTrans.TransactionLines = entity.TransactionLines;
            foundTrans.PaymentMethod = entity.PaymentMethod;
            foundTrans.TotalPrice = entity.TotalPrice;
            foundTrans.TotalCost = entity.TotalCost;

            await context.SaveChangesAsync();
        }
    }
}