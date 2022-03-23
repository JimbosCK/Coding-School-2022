using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class CoffeeShop {
        public List<Customer> Customers { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<ProductCategory> ProductCats { get; set; } = new();
        public List<Employee> Employees { get; set; } = new();
        public List<Transaction> Transactions { get; set; } = new();
    }
}
