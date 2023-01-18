
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Blazor.Shared.ViewModels
{
    public class LedgerViewModel
    {
        public int Year => Date.Year;
        public int Month => Date.Month;
        public DateTime Date { get; set; }
        [Range(-99999.99, 99999.99)]
        public decimal Income { get; set; }
        [Range(-99999.99, 99999.99)]
        public decimal Expenses { get; set; }
        [Range(-99999.99, 99999.99)]
        public decimal Total { get; set; }

    }
}
