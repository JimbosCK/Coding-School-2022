
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Model;
public class TransactionLine : BaseEntity{
    public Guid ProductID { get; set; }
    public Guid TransactionID { get; set; }
    public int Quantity { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal DiscountPerCent { get; set; }
    [Column(TypeName = "decimal(6,2)")] 
    public decimal Discount { get; set; }
    [Column(TypeName = "decimal(6,2)")] 
    public decimal DisplayPrice { get; set; }
    [Column(TypeName = "decimal(6,2)")] 
    public decimal TotalPrice { get; set; }
    [Column(TypeName = "decimal(6,2)")] 
    public decimal TotalCost { get; set; }

    public TransactionLine() {
        ID = Guid.NewGuid();

    }
}
