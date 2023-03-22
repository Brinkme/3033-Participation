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

namespace GameofThornes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string URL = $"https://api.gameofthronesquotes.xyz/v1/random";

            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(URL).Result;

                var api = JsonConvert.DeserializeObject<GameofThrones>(json);

                lstBox.Items.Add(api.sentence);
            }


            //string URL = $"https://api.gameofthronesquotes.xyz/v1/characters";
            //string json;

            //using (var client = new HttpClient())
            //{
            //    json = client.GetStringAsync(URL).Result;

            //    var api = JsonConvert.DeserializeObject<List<Class2>>(json);

            //    foreach (var item in api)
            //    {

            //        if (cmbBox.Items.Contains(item.name) == false)
            //        {
            //        cmbBox.Items.Add(item.name);

            //        }
            //    }
            //}

        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
        }

        private void cmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            string URL = $"https://api.gameofthronesquotes.xyz/v1/characters";
            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(URL).Result;

                var api = JsonConvert.DeserializeObject<List<House2>>(json);

                foreach (var item in api)
                {
                    MessageBox.Show($"{item.slug}");
                }

            }
        }
    }
}
