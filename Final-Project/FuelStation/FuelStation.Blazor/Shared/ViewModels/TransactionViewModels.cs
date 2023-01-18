
using FuelStation.Model;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class TransactionViewModel
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public Guid CustomerID { get; set; }
        public string? CustomerCardNumber { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }

    public class TransactionLineViewModel
    {
        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
    }

    public class TransactionVesselViewModel
    {
        public TransactionViewModel Transaction { get; set; }
        public List<TransactionLineViewModel> TransactionLists { get; set; } = new();
    }
}
