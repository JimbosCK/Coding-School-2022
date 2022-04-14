
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormTransactionList : XtraFormWithServerConnection
    {
        private List<TransactionViewModel> _transactionList = new();
        private FormRepositoryHandler _formRepoHandler;

        public FormTransactionList()
        {
            _formRepoHandler = (FormRepositoryHandler)Program.ServiceProvider.GetService(typeof(FormRepositoryHandler));
            InitializeComponent();
        }

        private async void FormTransactionList_Load(object sender, EventArgs e)
        {
            try
            {
                _transactionList = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("transaction");
                _formRepoHandler.PopulatePaymentMethod(repositoryPaymentMethod);
                SetUpBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error retrieving Data from database.\n[{ex}]",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Btn Clicks
        private void btnNew_Click(object sender, EventArgs e)
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
