
using FuelStation.Model;

namespace FuelStation.Blazor.Shared.Services
{
    public class AccessHandler
    {
        public bool HasAccessToItems(AppState appState)
        {
            return appState.LoggedIn &&
               (
               appState.EmployeeType == EmployeeTypeEnum.Administrator ||
               appState.EmployeeType == EmployeeTypeEnum.Manager ||
               appState.EmployeeType == EmployeeTypeEnum.Staff
               );
        }

        public bool HasAccessToCustomers(AppState appState)
        {
            return appState.LoggedIn &&
            (
                appState.EmployeeType == EmployeeTypeEnum.Administrator ||
                appState.EmployeeType == EmployeeTypeEnum.Manager ||
                appState.EmployeeType == EmployeeTypeEnum.Cashier
            );
        }

        public bool HasAccessToEmployees(AppState appState)
        {
            return appState.LoggedIn &&
            (
                appState.EmployeeType == EmployeeTypeEnum.Administrator ||
                appState.EmployeeType == EmployeeTypeEnum.Manager
            );
        }

        public bool HasAccessToLedger(AppState appState)
        {
            return appState.LoggedIn &&
            (
                appState.EmployeeType == EmployeeTypeEnum.Administrator ||
                appState.EmployeeType == EmployeeTypeEnum.Manager
            );
        }
    }
}
