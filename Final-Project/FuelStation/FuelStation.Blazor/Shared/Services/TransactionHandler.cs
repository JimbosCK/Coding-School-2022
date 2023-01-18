
using FuelStation.Blazor.Shared.ViewModels;

namespace FuelStation.Blazor.Shared.Services
{
    public class TransactionHandler
    {
        private decimal discountPercentFuel = 10.0m;

        public TransactionLineViewModel CreateTransactionLine(Guid transactionID, ItemListViewModel item, int quantity)
        {

            var netValue = quantity * item.Price;
            var discountPercent = 0.0m;


            if (HasFuelDiscount(item.ItemType, netValue))
            {
                discountPercent = discountPercentFuel;
            }

            var discountValue = netValue * discountPercent / 100;

            return new TransactionLineViewModel()
            {
                TransactionID = transactionID,
                ItemID = item.ID,
                ItemName = item.Description,
                ItemType = item.ItemType,
                Quantity = quantity,
                ItemPrice = item.Price,
                NetValue = netValue,
                DiscountPercent = discountPercent,
                DiscountValue = discountValue,
                TotalValue = netValue - discountValue
            };
        }
        public TransactionViewModel UpdateTransaction(TransactionViewModel transaction, List<TransactionLineViewModel> transactionLines)
        {
            transaction.TotalValue = transactionLines.Sum(x => x.TotalValue);
            return transaction;
        }
        public bool HasToPayWithCash(decimal TotalValue)
        {
            return TotalValue > 50;
        }
        public bool CanAddFuelItem(List<TransactionLineViewModel> transactionLInes, Model.ItemTypeEnum newItemType)
        {
            if (newItemType == Model.ItemTypeEnum.Fuel)
            {
                if (transactionLInes.Where(x => x.ItemType == Model.ItemTypeEnum.Fuel).Count() > 0) return false;
            }

            return true;
        }
        private bool HasFuelDiscount(Model.ItemTypeEnum itemType, decimal netValue)
        {
            return itemType == Model.ItemTypeEnum.Fuel && netValue > 20.0m;
        }
    }
}
