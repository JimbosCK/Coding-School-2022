
namespace CoffeeShop.Model;

public class ProductCategory : BaseEntity{
    public string Code { get; set; }
    public string Description { get; set; }
    public ProductType ProductType { get; set; }
    public ProductCategory() {
        ID = Guid.NewGuid();
    }
    public Product Product { get; set; }
    public ProductCategory ShallowCopy() {
        return (ProductCategory)MemberwiseClone();
    }
}
