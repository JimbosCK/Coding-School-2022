
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Model;
public class Transaction : BaseEntity {
    public DateTime Date { get; set; }
    public Guid EmployeeID { get; set; }
    public Guid CustomerID { get; set; }
    public List<TransactionLine> TransactionLines { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal TotalPrice { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal TotalCost { get; set; }
    public Employee Employee { get; set; }
    public Customer Customer { get; set; }
    public Transaction() {
        ID = Guid.NewGuid();
        TransactionLines = new List<TransactionLine>();
    }
    public Transaction(Guid employeeID, Guid customerID) : this() {
        EmployeeID = employeeID;
        CustomerID = customerID;
    }
}
