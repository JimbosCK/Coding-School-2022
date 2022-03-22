namespace CoffeeShop.Model;

public class Product : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid ProductCategoryID { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }

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
