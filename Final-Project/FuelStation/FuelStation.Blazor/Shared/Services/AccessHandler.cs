﻿
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
                appState.EmployeeType == Model.EmployeeTypeEnum.Administrator ||
                appState.EmployeeType == Model.EmployeeTypeEnum.Manager ||
                appState.EmployeeType == Model.EmployeeTypeEnum.Cashier
            );
        }
    }
}
