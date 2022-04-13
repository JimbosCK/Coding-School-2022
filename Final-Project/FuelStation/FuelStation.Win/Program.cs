using FuelStation.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;
using FuelStation.Model;
using FuelStation.Blazor.Shared.Services;

namespace FuelStation.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static IServiceProvider ServiceProvider { get; private set; }
        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            //Actual Service
            services.AddSingleton<AppState>()
                .AddScoped<AccessHandler>()
                .AddScoped<IEntityRepo<Item>, ItemRepo>();
                

            ServiceProvider = services.BuildServiceProvider();

        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ConfigureServices();

            Application.Run(new FormLogin());
        }
       
    }
}