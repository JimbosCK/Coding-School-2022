using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Client.Shared
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
