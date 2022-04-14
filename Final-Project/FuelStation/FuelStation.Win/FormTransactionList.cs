
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormTransactionList : XtraFormWithServerConnection
    {
        private List<TransactionViewModel> _transactionList = new();
        public FormTransactionList()
        {
            InitializeComponent();
        }

        private async void FormTransactionList_Load(object sender, EventArgs e)
        {
            _transactionList = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("transaction");
            SetUpBindings();
        }

        #region Btn Clicks
        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void SetUpBindings()
        {
            bsTransactions.DataSource = _transactionList;
            grdCtrlTransactions.DataSource = bsTransactions;
        }

        #endregion
    }
}
