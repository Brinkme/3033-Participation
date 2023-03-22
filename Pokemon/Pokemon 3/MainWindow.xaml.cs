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

namespace Pokemon_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool showfront;
        bool showback;
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon?limit=120&offset=0";
            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<PokemonAPI>(json);

                foreach (var item in api.results)
                {
                    cmbPokemon.Items.Add(item);
                }
            }

        }

        private void cmbPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Results selected = (Results)cmbPokemon.SelectedItem;

            string url = selected.url;
            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<PokemonThing>(json);

                imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                showfront = false; 

                
            }

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Results selected = (Results)cmbPokemon.SelectedItem;

            string url = selected.url;
            string json;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<PokemonThing>(json);

                imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                showfront = false;

            string status = btnChange.Content.ToString().ToLower();
            switch (status)
            {
                case "show back":
                        imgSource.Source = new BitmapImage(new Uri(api.sprites.back_default));
                        showback = false;
                        btnChange.Content = "Show Front";
                        break;
                    case "show front":
                        imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                        showfront = false;
                        btnChange.Content = "Show Back";
                        break;
            }
            }


        }
    }
}
