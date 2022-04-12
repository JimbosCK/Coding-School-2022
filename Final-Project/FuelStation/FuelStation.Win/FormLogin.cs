using System.Text.Json;
using System.Net.Http.Json;
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http;
using DevExpress.XtraEditors;
using FuelStation.Blazor.Client.Shared;
using FuelStation.Blazor.Shared.Services;
using System.IO;

namespace FuelStation.Win
{
    public partial class FormLogin : XtraForm
    {
        private AppState _appState;
        private AccessHandler _accessHandler;
        private bool hidden = false;
        public FormHome refToHome { get; set; }
        public FormLogin()
        {
            _appState = (AppState)Program.ServiceProvider.GetService(typeof(AppState));
            _accessHandler = (AccessHandler)Program.ServiceProvider.GetService(typeof(AccessHandler));
            InitializeComponent();
            

        }
        
        public LoginViewModel login = new LoginViewModel();

        private HttpClient httpClient;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SetUpHttpServerConnection();
            InitializeLoginControls();
            bsLogin.DataSource = login;
            SetDataBindings();
            
        }
        private void SetUpHttpServerConnection()
        {
            using FileStream file = File.OpenRead("appsettings.json");
            UriViewModel uri = (UriViewModel)JsonSerializer.Deserialize(file, typeof(UriViewModel));
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(uri.BaseAddress);
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