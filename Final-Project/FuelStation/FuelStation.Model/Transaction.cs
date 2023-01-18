
namespace FuelStation.Model
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
