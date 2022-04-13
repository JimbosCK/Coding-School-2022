using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormItemList : XtraFormWithServerConnection
    {
        private List<ItemListViewModel> itemList;
        private FormRepositoryHandler _formRepoHandler;
        public FormItemList()
        {
            _formRepoHandler = (FormRepositoryHandler)Program.ServiceProvider.GetService(typeof(FormRepositoryHandler));
            InitializeComponent();
        }

        private async void FormItemList_Load(object sender, EventArgs e)
        {
            itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
            _formRepoHandler.PopulateItemType(repositoryItemType);
            var c = repositoryItemType;
            SetUpBindings();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenEditPage();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bsItems.Current is ItemListViewModel editItem)
                OpenEditPage(editItem);
        }
        private void OpenEditPage()
        {
            var newItem = new ItemListViewModel();
            newItem.ID = Guid.Empty;
            var formItemEdit = new FormItemEdit(newItem);
            formItemEdit.ShowDialog();

            grdViewItems.RefreshData();
        }

        private void OpenEditPage(ItemListViewModel editItem)
        {
            var formItemEdit = new FormItemEdit(editItem);
            formItemEdit.ShowDialog();

            grdViewItems.RefreshData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeletionIsConfirmed())
                _ = DeleteItem();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void SetUpBindings()
        {
            bsItems.DataSource = itemList;
            grdCtrlItems.DataSource = bsItems;
        }
        private bool DeletionIsConfirmed()
        {
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Item?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private async Task DeleteItem()
        {
            var item = bsItems.Current as ItemListViewModel;
            if (item is null)
                return;
            var response = await httpClient.DeleteAsync($"item/{item.ID}");
            response.EnsureSuccessStatusCode();
            bsItems.Remove(item);
        }
    }
}
