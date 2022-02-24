using Newtonsoft.Json;
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

namespace ChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbBoxCat.Items.Add("All");
            cmbBoxCat.SelectedIndex = 0;

            string URL = $"https://api.chucknorris.io/jokes/categories";

            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(URL).Result;

                var api = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (var item in api)
                {
                    cmbBoxCat.Items.Add(item);
                }

                //lstBoxJoke1.Items.Add(api.value);
            }
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            lstBoxJoke1.Items.Clear();

            if (cmbBoxCat.SelectedIndex == 0)
            {
                string URL = "https://api.chucknorris.io/jokes/random";
                string json;

                using (var client = new HttpClient())
                {
                    json = client.GetStringAsync(URL).Result;

                    Chuck api1 = JsonConvert.DeserializeObject<Chuck>(json);

                    lstBoxJoke1.Items.Add(api1.value);
                }

            }
            else
            {
                string url = $"https://api.chucknorris.io/jokes/random?category={cmbBoxCat.SelectedItem}";
                string JSON;

                using (var client = new HttpClient())
                {
                    JSON = client.GetStringAsync(url).Result;

                    Chuck api2 = JsonConvert.DeserializeObject<Chuck>(JSON);

                    lstBoxJoke1.Items.Add(api2.value);
                }

            }

        }
    }
}
