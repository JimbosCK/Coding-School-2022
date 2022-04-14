
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
        private async void FormFindCustomerPrompt_Shown(object sender, EventArgs e)
        {
            if (CustomerCardNumber != string.Empty)
            {
                var customers = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("customer");
                var FormTransactionEdit = new FormTransactionEdit(customers.SingleOrDefault(x=>x.CardNumber == CustomerCardNumber).ID);
                FormTransactionEdit.RefFindCustomerPrompt = this;
                FormTransactionEdit.Show();
                this.Hide();
            }
        }

        #region Btn Clicks
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ResetErrorLabel();

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
        private void ResetErrorLabel()
        {
            labelErrors.Text = string.Empty;
            _errorFindingUser = false;
        }
        private void ShowErrorLabel()
        {
            labelErrors.Text = "Could not find Customer's Card Number.";
        }


    }
}
