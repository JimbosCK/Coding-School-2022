
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
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
        private AppState _appState;

        public FormFindCustomerPrompt RefFindCustomerPrompt { get; set; }


        public FormTransactionEdit(Guid customerID)
        {
            _appState = (AppState)Program.ServiceProvider.GetService(typeof(AppState));
            _formRepoHandler = (FormRepositoryHandler)Program.ServiceProvider.GetService(typeof(FormRepositoryHandler));
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
                itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
                _formRepoHandler.PopulateItemType(repositoryItemType);
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
            if(DeletionIsConfirmed())
                DeleteTransactionLine();
        }
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            CreateNewLine();
            RefreshGrids();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save new Transaction
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

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

            var quantity = Convert.ToInt32(spinEditQuantity.Text);
            var netValue = quantity * selectedItem.Price;
            var discountPercent = 0.0m;
            var discountValue = netValue * discountPercent;

            transactionLineList.Add(new TransactionLineViewModel()
            {
               TransactionID = newTransaction.ID,
                ItemID = selectedItem.ID,
                ItemName = selectedItem.Description,
                Quantity = quantity,
                ItemPrice = selectedItem.Price,
                NetValue = netValue,
                DiscountPercent = discountPercent,
                DiscountValue = netValue * discountPercent,
                TotalValue = netValue - discountValue
            });
        }
        private void RefreshGrids()
        {
            grdCtrlTransactionLines.Refresh();
            grdViewTransactionLines.RefreshData();

            textEditTotalPrice.Text = newTransaction.TotalValue.ToString();

            spinEditQuantity.Text = "1";
        }
    }
}
