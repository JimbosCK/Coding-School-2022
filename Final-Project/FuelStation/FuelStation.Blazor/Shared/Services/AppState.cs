
using FuelStation.Model;

namespace FuelStation.Blazor.Shared.Services
{

    public class AppState
    {
        private bool _loggedIn;
        private EmployeeTypeEnum _employeeType;
        private Guid _employeeID;
        public event Action OnChange;
        public bool LoggedIn
        {
            get { return _loggedIn; }
            set
            {
                if (_loggedIn != value)
                {
                    _loggedIn = value;
                    NotifyStateChanged();
                }
            }
        }
        public EmployeeTypeEnum EmployeeType
        {
            get { return _employeeType; }
            set
            {
                if (_employeeType != value)
                {
                    _employeeType = value;
                    NotifyStateChanged();
                }
            }
        }
        public Guid EmployeeID
        {
            get { return _employeeID; }
            set
            {
                if (_employeeID != value)
                {
                    _employeeID = value;
                    NotifyStateChanged();
                }
            }
        }


        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}