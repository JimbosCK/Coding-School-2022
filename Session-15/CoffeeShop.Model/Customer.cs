using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model;

public class Customer : BaseEntity {
    public string Code { get; set; }
    public string Description { get; set; } = string.Empty;

    public Customer() {
        ID = Guid.NewGuid();
    }

    public Customer(string code) : this() {
        Code = code;
        Description = "Retail Customer";
    }

    public Customer ShallowCopy() {
        return (Customer)MemberwiseClone();
    }


}
