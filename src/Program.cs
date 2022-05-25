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
            Application.Run(new MainForm());
        }
    }
}