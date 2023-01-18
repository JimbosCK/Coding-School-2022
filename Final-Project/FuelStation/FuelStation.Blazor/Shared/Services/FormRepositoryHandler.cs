using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using FuelStation.Model;

namespace FuelStation.Win
{
    public class FormRepositoryHandler
    {
        public void PopulateItemType(RepositoryItemLookUpEdit lookup)
        {
            var types = new Dictionary<ItemTypeEnum, string>()
        {
            { ItemTypeEnum.Product, "Product" },
            { ItemTypeEnum.Service, "Service" },
            { ItemTypeEnum.Fuel, "Fuel" }
        };

            lookup.DataSource = types;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
        }
        public void PopulatePaymentMethod(RepositoryItemLookUpEdit lookup)
        {
            var types = new Dictionary<PaymentMethodEnum, string>()
            {
                { PaymentMethodEnum.CreditCard, "Credit Card" },
                { PaymentMethodEnum.Cash, "Cash" }
            };

            lookup.DataSource = types;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
        }
    }
}
