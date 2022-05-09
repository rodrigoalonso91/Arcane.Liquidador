using Arcane.Itec.Abstractions;
using Arcane.Itec.ReportManager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Arcane.Liquidador
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IReportHandler, CsvReportHandler>()
                    .AddScoped<MainForm>();
        }
    }
}