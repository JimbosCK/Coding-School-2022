using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeNoir.Core;

public class Customer {
    public Guid ID { get; } = Guid.NewGuid();
    public string Code { get; set; }
    public string Description { get; set; } = string.Empty;

    //public static Customer RetailCustomer { get; } = new Customer("001")
    //{
    //    Description = "Retail Customer"
    //};

    public Customer(string code) {
        Code=code;
        Description = "Retail Customer";
    }

    public Customer ShallowCopy() {
        return (Customer)MemberwiseClone();
    }


}
