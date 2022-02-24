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
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string URL = "https://api.chucknorris.io/jokes/random";

            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(URL).Result;

                Chuck api = JsonConvert.DeserializeObject<Chuck>(json);

                lstBoxJoke1.Items.Add(api.value);
            }
        }

        private void lstBoxJoke1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //lstBoxJoke1.SelectedItem = thing;

            Chuck selected = (Chuck)lstBoxJoke1.SelectedItem;

            imgChuck.Source = new BitmapImage(new Uri(selected.icon_url));
        }
    }
}
