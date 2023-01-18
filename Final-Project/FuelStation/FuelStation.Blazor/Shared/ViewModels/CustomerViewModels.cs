
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class CustomerListViewModel
    {
        public Guid ID { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string FullName { get; set; }
    }

    public class CustomerViewModel
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Name has max length 20 characters.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Surname has max length 20 characters.")]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"^A[a-zA-Z-0-9]{1,19}$", 
            ErrorMessage = "Card number should start with the Letter 'A' and has max length 20 characters.")]
        public string CardNumber { get; set; }
    }
}
