
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormCustomerList : XtraFormWithServerConnection
    {
        private List<CustomerListViewModel> customerList = new();
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private async void FormCustomerList_Load(object sender, EventArgs e)
        {
            customerList = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
            SetUpBindings();
        }

        #region Btn Clicks
        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenEditPage(null);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bsCustomers.Current is CustomerListViewModel editCustomer)
                OpenEditPage(editCustomer);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeletionIsConfirmed())
                _ = DeleteCustomer();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        private void SetUpBindings()
        {
            bsCustomers.DataSource = customerList;
            grdCtrlCustomers.DataSource = bsCustomers;
        }
        private async void OpenEditPage(CustomerListViewModel? editItem)
        {
            if (editItem is null)
            {
                editItem = new CustomerListViewModel();
                editItem.ID = Guid.Empty;
            }
            var formItemEdit = new FormCustomerEdit(editItem);
            var result = formItemEdit.ShowDialog();

            if (result == DialogResult.OK) await UpdateListWithLatest();
        }
        private async Task UpdateListWithLatest()
        {
            customerList = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
            bsCustomers.DataSource = customerList;
            grdCtrlCustomers.Refresh();
        }
        private bool DeletionIsConfirmed()
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Customer?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private async Task DeleteCustomer()
        {
            var customer = bsCustomers.Current as CustomerListViewModel;
            if (customer is null)
                return;
            var response = await httpClient.DeleteAsync($"customer/{customer.ID}");
            response.EnsureSuccessStatusCode();
            bsCustomers.Remove(customer);
        }
        #endregion
    }
}
