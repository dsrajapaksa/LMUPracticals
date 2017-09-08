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
using Newtonsoft.Json;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AllRates _allRates;
        const string All_Rates_URL = @"https://openexchangerates.org/api/latest.json?app_id=0a001572f32142a2aeb6bff88293609d";


        public MainWindow()
        {
            InitializeComponent();
            _allRates = new AllRates();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

            HttpClient httpClinet = new HttpClient();
            string response = await httpClinet.GetStringAsync(All_Rates_URL);


            _allRates = JsonConvert.DeserializeObject<AllRates>(response);

            textBlock5.Text = _allRates.rates.AED.ToString();
        }
    }
}
