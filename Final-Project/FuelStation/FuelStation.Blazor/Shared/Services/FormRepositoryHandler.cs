using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
