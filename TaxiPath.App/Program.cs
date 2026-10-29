using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaxiPath.App
{
    /// <summary>
    /// Entry point for the TaxiPath application
    /// </summary>
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            // Create and run the application
            var app = new Application();
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}