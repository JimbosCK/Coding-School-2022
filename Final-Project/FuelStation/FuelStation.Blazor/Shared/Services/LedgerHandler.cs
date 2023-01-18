
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;

namespace FuelStation.Blazor.Shared.Services
{
    public class LedgerHandler
    {
        private int _year;
        private int _month;
        private decimal _income;
        private decimal _expenses;
        private decimal _total;

        private decimal _tranasctionsTotalPrice;
        private decimal _employeesTotalCost;
        private decimal _monthlyRentCost;
        private int _daysPayedPerMonth = 28;
        public LedgerViewModel MakeLedger(IEnumerable<Employee>? employees, IEnumerable<Transaction>? transactions, decimal monthlyRent, int year, int month)
        {
            _year = year;
            _month = month;
            _tranasctionsTotalPrice = transactions is null ? 0 : GetTransactionsTotal(transactions);

            _employeesTotalCost = employees is null ? 0 : GetEmployeesTotalCost(employees);

            //Expenses
            _monthlyRentCost = monthlyRent;
            _expenses = _monthlyRentCost + _employeesTotalCost;

            //Income
            _income = _tranasctionsTotalPrice;

            //Total
            _total = _income - _expenses;

            return new LedgerViewModel()
            {
                Expenses = _expenses,
                Income = _income,
                Date = new DateTime(year, month, 1),
                Total = _total
            };
        }
        private decimal GetEmployeesTotalCost(IEnumerable<Employee> employees)
        {
            var currentEmployees = GetCurrentEmployees(employees);
            if (currentEmployees is null) return 0;

            decimal totalEmployeeCost = 0;
            foreach (var employee in currentEmployees)
            {
                if (employee.HireDateEnd is not null)
                    totalEmployeeCost += CalculateCostForTerminatedEmployees(employee);

                else
                    totalEmployeeCost += CalculateCostForActiveEmployees(employee);
            }

            return totalEmployeeCost;
        }

        private decimal CalculateCostForActiveEmployees(Employee employee)
        {
            if (IsCurrentMonth())
            {
                return DateTime.Now.Day * (employee.SallaryPerMonth / _daysPayedPerMonth);
            }

            return employee.SallaryPerMonth;
        }

        private bool IsCurrentMonth()
        {
            return _month == DateTime.Now.Month && _year == DateTime.Now.Year;
        }
        private decimal CalculateCostForTerminatedEmployees(Employee employee)
        {
            if (employee.HireDateEnd.Value.Month == _month && employee.HireDateEnd.Value.Year == _year)
            {
                return employee.HireDateEnd.Value.Day * (employee.SallaryPerMonth / _daysPayedPerMonth);
            }

            return employee.SallaryPerMonth;
        }

        private IEnumerable<Employee> GetCurrentEmployees(IEnumerable<Employee> employees)
        {
            return employees.Where(x => ((x.HireDateStart.Year < _year) || (x.HireDateStart.Year == _year && x.HireDateStart.Month <= _month)) &&
                                        (x.HireDateEnd is null ||
                                        ((x.HireDateEnd.Value.Year == _year && x.HireDateEnd.Value.Month >= _month) ||
                                        (x.HireDateEnd.Value.Year > _year))));
        }

        private decimal GetTransactionsTotal(IEnumerable<Transaction> transactions)
        {
            var currentTransactions = GetCurrentTransactions(transactions);
            return currentTransactions.Sum(x => x.TotalValue);
        }

        private IEnumerable<Transaction> GetCurrentTransactions(IEnumerable<Transaction> transactions)
        {
            return transactions.Where(x => x.Date.Month == _month &&
                                      x.Date.Year == _year);
        }
    }
}
