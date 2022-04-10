using System.Text.Json;
using System.Net.Http.Json;
using FuelStation.Blazor.Shared.ViewModels;
using System.Net.Http;

namespace FuelStation.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Startup();

        }
        private async void  Startup()
        {
            /*var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7163/");
            var response = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
            int x =5;*/
        }
    }
}