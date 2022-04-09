
namespace FuelStation.Model
{
    public class Employee : Person
    {
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
