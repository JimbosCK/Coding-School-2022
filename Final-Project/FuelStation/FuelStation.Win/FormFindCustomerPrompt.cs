
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormFindCustomerPrompt : XtraFormWithServerConnection
    {
        private bool _errorFindingUser = false;
        private Guid _customerID;
        public string CustomerCardNumber { get; set; } = string.Empty;
        public FormFindCustomerPrompt()
        {
            InitializeComponent();
        }
        private void FormFindCustomerPrompt_VisibleChanged(object sender, EventArgs e)
        {
            if (! string.IsNullOrEmpty(CustomerCardNumber))
            {
                OpenTransactionLineEdit(CustomerCardNumber);
            }
        }

        #region Btn Clicks
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ResetErrorLabel();
                OpenTransactionLineEdit(textEditCustomerCardNumber.Text);

            }
            catch (Exception ex)
            {
                _errorFindingUser = true;
            }
            if (_errorFindingUser) ShowErrorLabel();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var formCustomerEdit = new FormCustomerEdit(null);
            formCustomerEdit.RefFindCustomerPrompt = this;
            formCustomerEdit.ShowDialog();
            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods
        private async void OpenTransactionLineEdit(string customerCardNumber)
        {
            try
            {
                var customer = await httpClient.GetFromJsonAsync<CustomerViewModel>($"customer/cardnumber/{customerCardNumber}");
                if(customer is null)
                {
                    _errorFindingUser = true;
                    return;
                }
                var formTransactionEdit = new FormTransactionEdit(customer.ID);
                formTransactionEdit.RefFindCustomerPrompt = this;
                formTransactionEdit.ShowDialog();
                this.Hide();
            }
            catch(Exception e)
            {
                _errorFindingUser = true;
            }
            if (_errorFindingUser) ShowErrorLabel();
        }
        private void ResetErrorLabel()
        {
            labelErrors.Text = string.Empty;
            _errorFindingUser = false;
        }
        private void ShowErrorLabel()
        {
            labelErrors.Text = "Could not find Customer's Card Number.";
        }
        #endregion
    }
}
