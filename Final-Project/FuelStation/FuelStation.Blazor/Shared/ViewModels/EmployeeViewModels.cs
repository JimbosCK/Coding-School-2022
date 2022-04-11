using FuelStation.Model;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class VerifiedEmployeeViewModel
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
    }

    public class EmployeeListViewModel
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public DateTime HireDateStart { get; set; }
        public decimal SallaryPerMonth { get; set; }
    }

    public class EmployeeViewModel
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public EmployeeTypeEnum EmployeeType { get; set; }
        [Required]
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        [Required]
        public decimal SallaryPerMonth { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }
}