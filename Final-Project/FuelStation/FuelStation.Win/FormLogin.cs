using System.Net.Http.Json;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.Blazor.Client.Shared;
using FuelStation.Blazor.Shared.Services;

namespace FuelStation.Win
{
    public partial class FormLogin : XtraFormWithServerConnection
    {
        public FormHome refToHome { get; set; }
        private AppState _appState;
        private bool hidden = false;
        public LoginViewModel login = new LoginViewModel();

        public FormLogin()
        {
            _appState = (AppState)Program.ServiceProvider.GetService(typeof(AppState));
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Width, Height);
            InitializeLoginControls();
            bsLogin.DataSource = login;
            SetDataBindings();

        }

        private void InitializeLoginControls()
        {
            textEditUsername.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            textEditPassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            textEditPassword.Properties.PasswordChar = '*';

        }
        private void SetDataBindings()
        {
            textEditUsername.DataBindings.Add(new Binding("EditValue", bsLogin, "Username", true));
            textEditPassword.DataBindings.Add(new Binding("EditValue", bsLogin, "Password", true));
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            hidden = false;
            labelError.Text = "";
            var verifiedEmployee = await httpClient.GetFromJsonAsync<VerifiedEmployeeViewModel>($"login/{(login.Username)}/{login.Password}");

            if (verifiedEmployee is not null)
            {
                if (verifiedEmployee.Username is not null)
                {
                    _appState.LoggedIn = true;
                    _appState.EmployeeType = verifiedEmployee.EmployeeType;

                    if (refToHome is null)
                    {
                        var home = new FormHome();
                        home.RefToLogin = this;
                        home.Show();
                    }
                    else
                    {
                        refToHome.Show();
                    }

                    hidden = true;
                    this.Hide();
                }
            }
            if (!hidden)
            {
                ShowErrorMessage();
            }
        }

        private void ShowErrorMessage()
        {
            labelError.Text = "Incorrect Username or password. Try again.";
        }
    }
}