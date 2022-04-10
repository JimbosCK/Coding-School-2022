using FuelStation.Model;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class VerifiedEmployeeViewModel
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
    }
}
