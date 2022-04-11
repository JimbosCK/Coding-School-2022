
using FuelStation.Blazor.Shared.ViewModels;

namespace FuelStation.Blazor.Shared.Services
{
    public class CustomerHandler
    {
        private int _nameMaxLength = 20;
        private int _surnameMaxLength = 20;
        private int _cardNumberMaxLength = 20;

        private int _nameMinLength = 1;
        private int _surnameMinLength = 1;
        private int _cardNumberMinLength = 2;

        private char _firstCardNumberCharacter = 'A';

        public bool HasValidData(CustomerViewModel customer)
        {
            return
                IsValidName(customer.Name) &&
                IsValidSurname(customer.Surname) &&
                IsValidCardNumber(customer.CardNumber);

        }

        private bool IsValidCardNumber(string cardNumber)
        {
            if (cardNumber == null) return false;
            if (cardNumber.Length < _cardNumberMinLength) return false;

            return cardNumber.Length <= _cardNumberMaxLength &&
                cardNumber[0] == _firstCardNumberCharacter;
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
    }
}
