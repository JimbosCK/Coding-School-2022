
using FuelStation.Blazor.Shared.ViewModels;

namespace FuelStation.Win
{
    public partial class FormTransactionList : XtraFormWithServerConnection
    {
        private List<TransactionViewModel> _transactionList = new();
        public FormTransactionList()
        {
            InitializeComponent();
        }

        private void FormTransactionList_Load(object sender, EventArgs e)
        {

        }
    }
}
