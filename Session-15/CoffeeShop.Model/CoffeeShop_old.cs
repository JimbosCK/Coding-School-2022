using System.Text.Json;
using System.Text.Json.Serialization;

namespace CoffeeShop.Model {
    [JsonSerializable(typeof(CoffeeShop_old.Dto))]
    internal partial class CoffeShopDtoSerializationContext : JsonSerializerContext { }

    public sealed class CoffeeShop_old {
        internal sealed class Dto {
            public List<Customer> Customers { get; set; } = new();
            public List<Product> Products { get; set; } = new();
            public List<ProductCategory> ProductCats { get; set; } = new();
            public List<Employee> Employees { get; set; } = new();
            public List<Transaction> Transactions { get; set; } = new();

            public static Dto? TryReadFromFile(string path) {
                try {
                    using FileStream file = File.OpenRead(path);
                    return JsonSerializer.Deserialize(file, CoffeShopDtoSerializationContext.Default.Dto);
                }
                catch (FileNotFoundException) {
                    return null;
                }
            }

            public void WriteToFile(string path) {
                using FileStream file = File.Create(path);
                JsonSerializer.Serialize(file, this, CoffeShopDtoSerializationContext.Default.Dto);
            }
        }

        private readonly string? _dataPath;

        private Dto _dto;

        private CoffeeShopLimits _limits;

        public List<Customer> Customers => _dto.Customers;
        public List<Product> Products => _dto.Products;
        public List<ProductCategory> ProductCats => _dto.ProductCats;
        public ICollection<Employee> Employees { get; }
        public List<Transaction> Transactions => _dto.Transactions;
        public decimal RentingCost { get; set; } = 3000m;

        public Customer RetailCustomer { get; }

        private Customer GetOrCreateRetailCustomer() {
            const string retailCustomerCode = "001";
            const string retailCustomerDescription = "Retail Customer";

            Customer? retailCustomerMaybe =
                Customers
                .SingleOrDefault(x =>
                    x.Code.Equals(retailCustomerCode, StringComparison.Ordinal)
                    // The description does not have to be equal ordinally; it is just a descrpitive string.
                    || x.Description.Equals(retailCustomerDescription, StringComparison.InvariantCultureIgnoreCase));

            if (retailCustomerMaybe == null) {
                retailCustomerMaybe = new Customer(retailCustomerCode) { Description = retailCustomerDescription };
                Customers.Add(retailCustomerMaybe);
            }

            return retailCustomerMaybe;
        }

        public CoffeeShop_old(string? dataPath, CoffeeShopLimits? limits, out bool createdNew) {
            _limits ??= CoffeeShopLimits.Default;
            createdNew = true;

            _dataPath = dataPath;
            Dto? dto = null;
            if (dataPath != null) {
                dto = Dto.TryReadFromFile(dataPath);
                createdNew = dto == null;
            }

            _dto = dto ?? new();

            Employees = new EmployeeCollection(_dto.Employees, _limits);
            RetailCustomer = GetOrCreateRetailCustomer();
        }

        public void SaveChanges() {
            // Check if it is not null and store it to a local.
            if (_dataPath is string dataPath) {
                _dto.WriteToFile(dataPath);
            }
        }

        public void ReloadChanges() {
            if (_dataPath is not string dataPath)
                return;

            Dto? dto = Dto.TryReadFromFile(dataPath);
            if (dto != null)
                _dto = dto;
        }
    }
}
