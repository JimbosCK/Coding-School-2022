﻿using FuelStation.Blazor.Shared.ViewModels;
using System.IO;
using System.Net.Http;
using System.Text.Json;

namespace FuelStation.Win
{
    public class XtraFormWithServerConnection : FuelStationXtraForm
    {
        protected HttpClient httpClient = new();

        public XtraFormWithServerConnection()
        {
            SetUpHttpServerConnection();
        }
        private void SetUpHttpServerConnection()
        {
            using FileStream file = File.OpenRead("appsettings.json");
            UriViewModel uri = (UriViewModel)JsonSerializer.Deserialize(file, typeof(UriViewModel));
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(uri.BaseAddress);
        }
    }
}
