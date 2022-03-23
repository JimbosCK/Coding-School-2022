using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Model;

public class Product : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid ProductCategoryID { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }
    [Column(TypeName = "decimal(6,2)")]
    public decimal Cost { get; set; }

    public CoffeeShopMain Shop { get; set; }
    public ProductCategory ProductCategory { get; set; }
    public TransactionLine TransactionLine { get; set; }
    public Product() {
        ID = Guid.NewGuid();
    }
    public Product(Guid productCategoryID) : this() {
        ProductCategoryID = productCategoryID;
    }


    public Product ShallowCopy() {
        return (Product)MemberwiseClone();
    }
}
