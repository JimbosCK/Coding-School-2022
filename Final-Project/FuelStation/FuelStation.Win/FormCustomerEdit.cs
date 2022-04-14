
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormCustomerEdit : XtraFormWithServerConnection
    {
        private CustomerViewModel _customer;
        private CustomerViewModel _backupCustomer;
        private CustomerListViewModel _customerListViewmodel;

        public FormFindCustomerPrompt RefFindCustomerPrompt { get; set; } = null;

        private bool codeAlreadyExists = false;
        private bool customerDoesNotExist = false;
        private bool databaseError = false;

        public FormCustomerEdit(CustomerListViewModel customerListViewmodel)
        {
            _customerListViewmodel = customerListViewmodel;
            _customer = new CustomerViewModel();
            _backupCustomer = new CustomerViewModel();
            _ = InitializeCustomer();
            
            InitializeComponent();
        }
        private void FormCustomerEdit_Load(object sender, EventArgs e)
        {
            SetUpBindings();
        }

        #region Button Clicks
        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = OnSave();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(RefFindCustomerPrompt is not null)
            {
                RefFindCustomerPrompt.Show();
                this.Close();
            }
            CopyItem(_backupCustomer, _customer);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Methods
        private void SetUpBindings()
        {
            bsCustomer.DataSource = _customer;

            textEditName.DataBindings.Add(new Binding("EditValue", bsCustomer, "Name", true));
            textEditSurname.DataBindings.Add(new Binding("EditValue", bsCustomer, "Surname", true));
            textEditCardNumber.DataBindings.Add(new Binding("EditValue", bsCustomer, "CardNumber", true));
        }
        private void UpdateBindings()
        {
            bsCustomer.DataSource = _customer;
            textEditName.Refresh();
            textEditSurname.Refresh();
            textEditCardNumber.Refresh();
        }
        private async Task InitializeCustomer()
        {
            if(_customerListViewmodel is not null)
            {
                if (_customerListViewmodel.ID == Guid.Empty)
                    _customer = new CustomerViewModel();
                else
                    await GetCustomerViewModel(_customerListViewmodel.ID);
            }
        }
        private async Task GetCustomerViewModel(Guid editCustomerID)
        {
            try
            {
                _customer = await httpClient.GetFromJsonAsync<CustomerViewModel>($"customer/{editCustomerID}");
                CopyItem(_customer, _backupCustomer);
                UpdateBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error while trying to retrieve Customer with id{editCustomerID}.\n[{ex}]",
               this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
        private async Task OnSave()
        {
            HttpResponseMessage response;
            try
            {
                if (_customer.ID == Guid.Empty || _customer.ID == null)
                {
                    response = await httpClient.PostAsJsonAsync("customer", _customer);
                }
                else
                {
                    response = await httpClient.PutAsJsonAsync("customer", _customer);
                }

                if ((int)response.StatusCode == 422) codeAlreadyExists = true;
                if ((int)response.StatusCode == 404) customerDoesNotExist = true;
                if ((int)response.StatusCode == 500) databaseError = true;
                UpdateErrorMessages();
                response.EnsureSuccessStatusCode();
                this.DialogResult = DialogResult.OK;
                if (RefFindCustomerPrompt is not null)
                {
                    RefFindCustomerPrompt.CustomerCardNumber = _customer.CardNumber;
                    RefFindCustomerPrompt.Show();
                }
                this.Close();
            }
            catch (Exception)
            {
                databaseError = true;
            }
        }
        private void UpdateErrorMessages()
        {
            labelErrors.Text = "";
            if (codeAlreadyExists) labelErrors.Text += "Code already exists. ";
            if (customerDoesNotExist) labelErrors.Text += "Customer was not found. ";
            if (databaseError) labelErrors.Text += "Database error.";

            ResetErrorFlags();
        }
        private void ResetErrorFlags()
        {
            codeAlreadyExists = false;
            customerDoesNotExist = false;
            databaseError = false;
        }
        private void CopyItem(CustomerViewModel originCustomer, CustomerViewModel destinationCustomer)
        {
            destinationCustomer.ID = originCustomer.ID;
            destinationCustomer.Name = originCustomer.Name;
            destinationCustomer.Surname = originCustomer.Surname;
            destinationCustomer.CardNumber = originCustomer.CardNumber;
        }
        #endregion
    }
}
