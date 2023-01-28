
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormTransactionEdit : XtraFormWithServerConnection
    {
        private Guid _customerID;
        private List<TransactionLineViewModel> transactionLineList = new();
        private List<ItemListViewModel> itemList = new();
        private TransactionViewModel newTransaction = new();
        private FormRepositoryHandler _formRepoHandler;
        private TransactionHandler _transactionHandler;
        private AppState _appState;

        public FormFindCustomerPrompt RefFindCustomerPrompt { get; set; }


        public FormTransactionEdit(Guid customerID)
        {
            _appState = Program.ServiceProvider.GetService(typeof(AppState)) as AppState ?? new AppState();
            _transactionHandler = Program.ServiceProvider.GetService(typeof(TransactionHandler)) as TransactionHandler ?? new TransactionHandler();
            _formRepoHandler = Program.ServiceProvider.GetService(typeof(FormRepositoryHandler)) as FormRepositoryHandler ?? new FormRepositoryHandler();
            _customerID = customerID;

            newTransaction.Date = DateTime.Now;
            newTransaction.EmployeeID = _appState.EmployeeID;
            newTransaction.CustomerID = customerID;

            InitializeComponent();
        }

        private async void FormTransactionEdit_Load(object sender, EventArgs e)
        {
            try
            {
                itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item") ?? new List<ItemListViewModel>();
                _formRepoHandler.PopulateItemType(repositoryItemType);
                _formRepoHandler.PopulatePaymentMethod(lookUpPaymentMethod.Properties);
                lookUpPaymentMethod.EditValue = PaymentMethodEnum.Cash;
                SetUpBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error retrieving Data from database.\n[{ex}]",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Btn Clicks
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeletionIsConfirmed())
                DeleteTransactionLine();
            UpdateNewTransaction();
            RefreshGrids();
            ManagePaymentRestrictions();
        }
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            CreateNewLine();

            RefreshGrids();
            ManagePaymentRestrictions();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            labelErrors.Text = "";
            if (transactionLineList.Count > 0)
            {
                SaveTransaction();
            }
            else
            {
                MessageBox.Show(this, $"Can not add transaction with no lines!",
                this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Methods
        private void SetUpBindings()
        {
            bsItems.DataSource = itemList;
            grdCtrlItems.DataSource = bsItems;

            bsTransactionLines.DataSource = transactionLineList;
            grdCtrlTransactionLines.DataSource = bsTransactionLines;
        }
        private bool DeletionIsConfirmed()
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected  transaction line?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void DeleteTransactionLine()
        {
            var line = bsTransactionLines.Current as TransactionLineViewModel;
            if (line is null)
                return;
            bsTransactionLines.Remove(line);
            transactionLineList.Remove(line);
        }
        private void CreateNewLine()
        {
            var selectedItem = bsItems.Current as ItemListViewModel;
            if (selectedItem is null) return;

            if (_transactionHandler.CanAddFuelItem(transactionLineList, selectedItem.ItemType))
            {
                transactionLineList.Add(_transactionHandler.CreateTransactionLine(
                newTransaction.ID, selectedItem, Convert.ToInt32(spinEditQuantity.Text)));

                UpdateNewTransaction();
            }
            else
            {
                labelErrors.Text = "Can not add more than one item of type 'Fuel'.";
                return;
            }
        }
        private void ManagePaymentRestrictions()
        {
            if (_transactionHandler.HasToPayWithCash(newTransaction.TotalValue))
            {
                lookUpPaymentMethod.EditValue = PaymentMethodEnum.Cash;
                lookUpPaymentMethod.Enabled = false;
            }
            else
            {
                lookUpPaymentMethod.Enabled = true;
            }
        }
        private void UpdateNewTransaction()
        {
            newTransaction = _transactionHandler.UpdateTransaction(newTransaction, transactionLineList);
        }
        private void RefreshGrids()
        {
            grdCtrlTransactionLines.Refresh();
            grdViewTransactionLines.RefreshData();

            labelTotalPrice.Text = $"Total: {newTransaction.TotalValue} €";

            spinEditQuantity.Text = "1";
        }
        private async void SaveTransaction()
        {
            newTransaction.PaymentMethod = (PaymentMethodEnum)lookUpPaymentMethod.EditValue;
            var transactionVessel = new TransactionVesselViewModel()
            {
                Transaction = newTransaction,
                TransactionLists = transactionLineList
            };

            HttpResponseMessage response;
            try
            {
                response = await httpClient.PostAsJsonAsync("transaction", transactionVessel);

                if ((int)response.StatusCode == 500) labelErrors.Text = "Database Error.";
                if ((int)response.StatusCode == 500) labelErrors.Text = "Database Error. Maybe admin role.";
                response.EnsureSuccessStatusCode();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                labelErrors.Text = "Database Error.";
            }
        }
        #endregion
    }
}
