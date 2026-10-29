using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TaxiPath.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Title = "TaxiPath";
            this.Width = 1200;
            this.Height = 800;
            
            // Create a simple layout for now
            var mainPanel = new Grid();
            this.Content = mainPanel;
            
            // Simple placeholder content
            var label = new Label()
            {
                Content = "TaxiPath Application - Foundation Built",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20,
                FontWeight = FontWeights.Bold
            };
            
            mainPanel.Children.Add(label);
        }
    }
}