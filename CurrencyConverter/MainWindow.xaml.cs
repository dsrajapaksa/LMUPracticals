﻿using System;
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
using System.Reflection;
using System.IO;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AllRates _allRates;
        SingleRate _singleRate;
        const string All_Rates_URL = @"https://openexchangerates.org/api/latest.json?app_id=0a001572f32142a2aeb6bff88293609d";


        public MainWindow()
        {
            InitializeComponent();
            _allRates = new AllRates();
            _singleRate = new SingleRate();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

            HttpClient httpClinet = new HttpClient();
            string response = await httpClinet.GetStringAsync(All_Rates_URL);


            _allRates = JsonConvert.DeserializeObject<AllRates>(response);

            
            //textBlock5.Text = _allRates.rates.AED.ToString();
        }

        private void Convert_click(object sender, RoutedEventArgs e)
        {
            // outPutText.Text = Convert.ToString( Convert.ToDouble(inPutText.Text)  * _allRates.rates.LKR);

            var fromTag = ((ComboBoxItem)fromComboBox.SelectedItem).Tag.ToString();
            var toTag = ((ComboBoxItem)toComboBox.SelectedItem).Tag.ToString();


            //This case matches only from USD to ANY
            switch (toTag)
            {
                case "LKR":
                    resultText.Text = Convert.ToString(Math.Round(Convert.ToDouble(inPutText.Text) * 
                        Convert.ToDouble(_allRates.rates.LKR), 2));
                    break;

                case "AED":
                    resultText.Text = Convert.ToString(Math.Round(Convert.ToDouble(inPutText.Text) * 
                        Convert.ToDouble(_allRates.rates.AED), 2));
                    break;

                case "SGD":
                    resultText.Text = Convert.ToString(Math.Round(Convert.ToDouble(inPutText.Text) *
                        Convert.ToDouble(_allRates.rates.SGD),2));
                    break;

                default:
                    break;  
            }


            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _singleRate.Id = 1;
            _singleRate.rate_From = fromComboBox.Text.ToString();
            _singleRate.rate_To = toComboBox.Text.ToString();
            _singleRate.rate = Convert.ToDouble(resultText.Text);

            string fileLocation = @"H:\VISUAL STUDIO\DemosLMU\LMUPracticals\CurrencyConverter\SaveData\";

            string serializedata = JsonConvert.SerializeObject(_singleRate);

            if(File.ReadAllText(fileLocation + "saved_rate.json")=="")
            {
                File.AppendAllText(fileLocation + "saved_rate.json", serializedata+",");
            }
            else
            {
                File.AppendAllText(fileLocation + "saved_rate.json", ","+serializedata);
            }
            
            //


            MessageBox.Show("Data Saved !");
        }
    }
}
