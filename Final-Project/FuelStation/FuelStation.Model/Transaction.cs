using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Transaction : BaseEntity
    {
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
    }
}
