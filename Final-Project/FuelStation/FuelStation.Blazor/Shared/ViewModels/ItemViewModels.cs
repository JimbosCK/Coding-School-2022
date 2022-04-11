
using FuelStation.Model;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class ItemListViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(6, ErrorMessage = "Code max length is 6 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Descritpion max length is 30 characters")]
        public string Description { get; set; }
        [Required]
        public ItemTypeEnum ItemType { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Price [0-99999.99]")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 99999.99, ErrorMessage = "Invalid Cost [0-99999.99]")]
        public decimal Cost { get; set; }
    }
}
