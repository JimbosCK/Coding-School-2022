
using FuelStation.Blazor.Shared.ViewModels;

namespace FuelStation.Win
{
    public partial class FormItemEdit : XtraFormWithServerConnection
    {
        public FormItemEdit(ItemListViewModel item)
        {
            InitializeComponent();
        }

        private void FormItemEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
