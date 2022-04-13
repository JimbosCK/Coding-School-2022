
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormItemEdit : XtraFormWithServerConnection
    {
        private FormRepositoryHandler _formRepoHandler;
        private ItemListViewModel _item;

        private bool codeAlreadyExists = false;
        private bool itemDoesNotExist = false;
        private bool databaseError = false;
        public FormItemEdit(ItemListViewModel item)
        {
            _item = item;
            _formRepoHandler = (FormRepositoryHandler)Program.ServiceProvider.GetService(typeof(FormRepositoryHandler));
            InitializeComponent();
        }

        private void FormItemEdit_Load(object sender, EventArgs e)
        {
            _formRepoHandler.PopulateItemType(lookUpEditItemType.Properties);
            SetUpBindings();

        }

        private void SetUpBindings()
        {
            bsItem.DataSource = _item;

            ctrlCode.DataBindings.Add(new Binding("EditValue", bsItem, "Code", true));
            ctrlDescription.DataBindings.Add(new Binding("EditValue", bsItem, "Description", true));
            ctrlPrice.DataBindings.Add(new Binding("EditValue", bsItem, "Price", true));
            ctrlCost.DataBindings.Add(new Binding("EditValue", bsItem, "Cost", true));
            ctrlItemType.DataBindings.Add(new Binding("EditValue", bsItem, "ItemType", true));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ = OnSave();
        }
        private async Task OnSave()
        {
            HttpResponseMessage response;
            try
            {
                if (_item.ID == Guid.Empty || _item.ID == null)
                {
                    response = await httpClient.PostAsJsonAsync("item", _item);
                }
                else
                {
                    response = await httpClient.PutAsJsonAsync("item", _item);
                }

                if ((int)response.StatusCode == 422) codeAlreadyExists = true;
                if ((int)response.StatusCode == 404) itemDoesNotExist = true;
                if ((int)response.StatusCode == 500) databaseError = true;
                UpdateErrorMessages();
                response.EnsureSuccessStatusCode();
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
            if (itemDoesNotExist) labelErrors.Text += "Item was not found. ";
            if (databaseError) labelErrors.Text += "Database error.";
            
            ResetErrorFlags();
        }
        private void ResetErrorFlags()
        {
            codeAlreadyExists = true;
            itemDoesNotExist = true;
            databaseError = true;
        }
    }
}