using FuelStation.Blazor.Shared.Services;
using System.ComponentModel;

namespace FuelStation.Win
{
    public partial class FormHome : FuelStationXtraForm
    {
        private AppState _appState;
        private AccessHandler _accessHandler;

        public FormLogin RefToLogin { get; set; }
        public FormHome()
        {
            _appState = (AppState)Program.ServiceProvider.GetService(typeof(AppState));
            _accessHandler = (AccessHandler)Program.ServiceProvider.GetService(typeof(AccessHandler));
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            RefToLogin.refToHome = this;
        }
        private void FormHome_Shown(Object sender, EventArgs e)
        {
            HandleAccess();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
            base.OnClosing(e);
        }

        private void menuItemsList_Click(object sender, EventArgs e)
        {
            var itemListForm = new FormItemList();
            itemListForm.ShowDialog();
        }
        private void menuCustomerList_Click(object sender, EventArgs e)
        {
            var customerListForm = new FormCustomerList();
            customerListForm.ShowDialog();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _appState.LoggedIn = false;
            this.Hide();
            RefToLogin.Show();
        }
        private void HandleAccess()
        {
            customersToolStripMenuItem.Visible = true;
            itemsToolStripMenuItem.Visible = true;
            transactionToolStripMenuItem.Visible = true;

            if (!_accessHandler.HasAccessToCustomers(_appState)) customersToolStripMenuItem.Visible = false;
            if (!_accessHandler.HasAccessToItems(_appState)) itemsToolStripMenuItem.Visible = false;
            if (!_accessHandler.HasAccessToTransactions(_appState)) transactionToolStripMenuItem.Visible = false;
        }


    }
}

