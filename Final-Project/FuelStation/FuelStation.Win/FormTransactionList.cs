
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
            _formRepoHandler = (FormRepositoryHandler)Program.ServiceProvider.GetService(typeof(FormRepositoryHandler)) ?? new FormRepositoryHandler();
            InitializeComponent();
        }

        private async void FormTransactionList_Load(object sender, EventArgs e)
        {
            try
            {
                _transactionList = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("transaction") ?? new List<TransactionViewModel>();
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
        private async void btnNew_Click(object sender, EventArgs e)
        {
            var formFindCustomer = new FormFindCustomerPrompt();
            var result = formFindCustomer.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel) await UpdateListWithLatest();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeletionIsConfirmed())
                _ = DeleteTransaction();
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
        private async void FormTransactionList_VisibleChanged(object sender, EventArgs e)
        {
            await UpdateListWithLatest();
        }
        private void RefreshGrids()
        {
            grdCtrlTransactions.Refresh();
            grdViewTransactions.RefreshData();

        }
        private bool DeletionIsConfirmed()
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Transaction?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private async Task DeleteTransaction()
        {
            var transaction = bsTransactions.Current as TransactionViewModel;
            if (transaction is null)
                return;
            var response = await httpClient.DeleteAsync($"transaction/{transaction.ID}");
            response.EnsureSuccessStatusCode();
            bsTransactions.Remove(transaction);
        }
        private async Task UpdateListWithLatest()
        {
            _transactionList = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("transaction") ?? new List<TransactionViewModel>();
            bsTransactions.DataSource = _transactionList;
            RefreshGrids();
        }
        #endregion
    }
}
