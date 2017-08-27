using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebServices
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String app_id = "";
        public String app_URL = "";
        public String response = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            progressBar.IsIndeterminate = true;

            app_id = appIdText.Text;
            app_URL = appUrl.Text;

            HttpClient httpClinet = new HttpClient();

            response = await httpClinet.GetStringAsync(app_URL + app_id);

            responseTextBox.Text = response;

            progressBar.IsIndeterminate = false;

        }
    }
}
