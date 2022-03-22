namespace CafeNoir.Core;

public sealed class CoffeeShopLimits
{
    public uint MinManagers { get; init; } = 1;
    public uint MaxManagers { get; init; } = 1;
    public uint MinCashiers { get; init; } = 1;
    public uint MaxCashiers { get; init; } = 2;
    public uint MinBaristas { get; init; } = 1;
    public uint MaxBaristas { get; init; } = 2;
    public uint MinWaiters { get; init; } = 1;
    public uint MaxWaiters { get; init; } = 3;

    public uint MinEmployees => MinManagers + MinCashiers + MinBaristas + MinWaiters;

    public (uint Min, uint Max) GetLimitsForType(EmployeeType type) => type switch
    {
        EmployeeType.Manager => (MinManagers, MaxManagers),
        EmployeeType.Cashier => (MinCashiers, MaxCashiers),
        EmployeeType.Barista => (MinBaristas, MaxBaristas),
        EmployeeType.Waiter => (MinWaiters, MaxWaiters),
        _ => throw new ArgumentOutOfRangeException(nameof(type)),
    };

    public static CoffeeShopLimits Default { get; } = new();

    public CoffeeShopLimits()
    {
    }
}
