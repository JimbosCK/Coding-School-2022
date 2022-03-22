using System.Collections.ObjectModel;

namespace CoffeeShop.Model;

internal sealed class EmployeeCollection : Collection<Employee>
{
    private readonly CoffeeShopLimits _limits;

    private void PopulateEmployees(EmployeeType type)
    {
        (uint minCount, uint maxCount) = _limits.GetLimitsForType(type);

        if (maxCount > 0 && minCount > maxCount)
            throw new ArgumentException($"{type}s cannot be both more than {minCount} and less than {maxCount}.");

        if (minCount == 0)
            return;

        var employeesOfThisType = (uint)Items.Count(x => x.EmployeeType == type);

        for (uint i = employeesOfThisType; i < minCount; i++)
        {
            Items.Add(new() { Name = type.ToString(), Surname = $"#{i}", EmployeeType = type });
        }
    }

    protected override void ClearItems()
    {
        if (_limits.MinEmployees > 0)
            throw new InvalidOperationException("Cannot fire all employees.");
        base.ClearItems();
    }

    protected override void SetItem(int index, Employee item)
    {
        if (this[index].EmployeeType != item.EmployeeType)
            throw new InvalidOperationException("Cannot change the type of an employee.");
        base.SetItem(index, item);
    }

    protected override void InsertItem(int index, Employee item)
    {
        EmployeeType type = item.EmployeeType;

        uint maxEmployeesOfThisType = _limits.GetLimitsForType(type).Max;
        var numEmployeesOfThisType = (uint)Items.Count(x => x.EmployeeType == type);

        if (numEmployeesOfThisType == maxEmployeesOfThisType)
            throw new InvalidOperationException($"Cannot add more than {maxEmployeesOfThisType} {type}s");
        base.InsertItem(index, item);
    }

    protected override void RemoveItem(int index)
    {
        Employee item = Items[index];
        EmployeeType type = item.EmployeeType;

        uint minEmployeesOfThisType = _limits.GetLimitsForType(type).Min;
        var numEmployeesOfThisType = (uint)Items.Count(x => x.EmployeeType == type);
        if (numEmployeesOfThisType == minEmployeesOfThisType)
            throw new InvalidOperationException($"Cannot have less than {minEmployeesOfThisType} {type}s");
        base.RemoveItem(index);
    }

    public EmployeeCollection(IList<Employee> list, CoffeeShopLimits limits) : base(list)
    {
        _limits = limits;

        PopulateEmployees(EmployeeType.Manager);
        PopulateEmployees(EmployeeType.Cashier);
        PopulateEmployees(EmployeeType.Barista);
        PopulateEmployees(EmployeeType.Waiter);
    }
}
