
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class FuelStationShopViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Cost [0-99999.99]")]
        public decimal MonthlyRentCost { get; set; }
    }
}
