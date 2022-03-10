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

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool showFront;
        private bool showBack;
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200&offset=0";
            string json;


            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<PokemonAPI>(json);

                foreach (var item in api.results)
                {
                    cmbBoxPokemon.Items.Add(item);
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Results  selected = (Results)cmbBoxPokemon.SelectedItem;
            string json;
            string url = selected.url;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<Pokemonthing>(json);

                imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                showFront = false;

                MessageBox.Show((api.ToString()));
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            Results selected = (Results)cmbBoxPokemon.SelectedItem;
            string json;
            string url = selected.url;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<Pokemonthing>(json);

                imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                showFront = false;

                string satus = btnChange.Content.ToString().ToLower();
                switch (satus)
                {
                    case "show back":
                        imgSource.Source = new BitmapImage(new Uri(api.sprites.back_default));
                        showBack = false;
                        btnChange.Content = "Show Front";
                        break;
                    case "show front":
                        imgSource.Source = new BitmapImage(new Uri(api.sprites.front_default));
                        btnChange.Content = "Show Back";
                        showFront = false;
                        break ;
                }
            }
        }
    }
}
