
using FuelStation.Blazor.Shared.ViewModels;

namespace FuelStation.Blazor.Shared.Services
{
    public class EmployeeHandler
    {
        private int _nameMaxLength = 20;
        private int _surnameMaxLength = 20;
        private int _usernameMaxLength = 20;
        private int _passwordMaxLength = 256;

        private int _nameMinLength = 1;
        private int _surnameMinLength = 1;
        private int _usernameMinLength = 1;
        private int _passwordMinLength = 1;

        public bool HasValidData(EmployeeViewModel employee)
        {
            return
                IsValidName(employee.Name) &&
                IsValidSurname(employee.Surname) &&
                IsValidUsername(employee.Username) &&
                IsValidPassword(employee.Password) &&
                IsValidSallary(employee.SallaryPerMonth) &&
                IsValidHireDateStart(employee.HireDateStart);
        }
        private bool IsValidSallary(decimal sallary)
        {
            if (sallary < 0) return false;

            return true;
        }
        private bool IsValidUsername(string username)
        {
            if (username == null) return false;
            if (username.Length < _usernameMinLength) return false;

            return username.Length <= _usernameMaxLength;
        }
        private bool IsValidPassword(string pasword)
        {
            if (pasword == null) return false;
            if (pasword.Length < _passwordMinLength) return false;

            return pasword.Length <= _passwordMaxLength;
        }
        private bool IsValidName(string name)
        {
            if (name == null) return false;
            if (name.Length < _nameMinLength) return false;

            return name.Length <= _nameMaxLength;
        }

        private bool IsValidSurname(string surname)
        {
            if (surname == null) return false;
            if (surname.Length < _surnameMinLength) return false;

            return surname.Length <= _surnameMaxLength;
        }
        private bool IsValidHireDateStart(DateTime date)
        {
            if (date == null) return false;
            if (date > DateTime.Now) return false;

            return true;
        }
    }
}
