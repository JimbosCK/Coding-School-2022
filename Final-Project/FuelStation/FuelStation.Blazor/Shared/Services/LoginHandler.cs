
namespace FuelStation.Blazor.Shared.Services
{
    public class LoginHandler
    {
        private string _adminUsername = "admin";
        private string _adminPassword = "admin";

        public LoginHandler()
        {
        }

        public bool IsAdministrator(string username, string password)
        {
            return username == _adminUsername && password == _adminPassword;
        }
        public bool HasInvalidCredentials(string username, string password)
        {
            return string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);
        }
    }
}
