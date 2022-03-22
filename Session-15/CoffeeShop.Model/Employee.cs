using System.Text.Json.Serialization;

namespace CoffeeShop.Model {
    public class Employee : BaseEntity {
        public string Name { get; set; }

        public string Surname { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public decimal SalaryPerMonth { get; set; }

        public Employee() {
            ID = Guid.NewGuid();
        }

        public Employee ShallowCopy() => (Employee)MemberwiseClone();
    }
}
