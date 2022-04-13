using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace FuelStation.Win
{
    public partial class FormItemList : XtraFormWithServerConnection
    {
        private AppState _appState;
        private AccessHandler _accessHandler;
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
            //OpenDetailsPage();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //OpenDetailsPage(productCategory);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeletionIsConfirmed())
                DeleteCategory();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
        private void DeleteCategory()
        {
            // TODO: Add Delete Item logic
        }


    }
}
