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
        public FormLogin()
        {
            _appState = (AppState)Program.ServiceProvider.GetService(typeof(AppState));
            _accessHandler = (AccessHandler)Program.ServiceProvider.GetService(typeof(AccessHandler)); ;
            InitializeComponent();
            

        }
        
        public LoginViewModel login = new LoginViewModel();

        private bool showErrorMessage = false;
        private HttpClient httpClient;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SetUpHttpServerConnection();

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
        private void SetDataBindings()
        {
            textEditUsername.DataBindings.Add(new Binding("EditValue", bsLogin, "Username", true));
            textEditPassword.DataBindings.Add(new Binding("EditValue", bsLogin, "Password", true));
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var verifiedEmployee = await httpClient.GetFromJsonAsync<VerifiedEmployeeViewModel>($"login/{(login.Username)}/{login.Password}");

            if (verifiedEmployee is not null)
            {
                if (verifiedEmployee.Username is not null)
                {
                    _appState.LoggedIn = true;
                    _appState.EmployeeType = verifiedEmployee.EmployeeType;
                    
                    this.Close();
                    //var formObject = new FormHome();
                }
            }

            showErrorMessage = true;
            ShowErrorMessage();
        }

        private void ShowErrorMessage()
        {
            labelError.Text = "Incorrect Username or password. Try again.";
        }


    }
}