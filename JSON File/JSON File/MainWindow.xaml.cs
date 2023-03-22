using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace JSON_File
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Owner> JasondDerulo = new List<Owner>();
        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("Mock_Data_Car_Owners.json");
            var results = JsonConvert.DeserializeObject<List<Owner>>(json);


            foreach (Owner owner in results)
            {
                if (cmbColor.Items.Contains(owner.Color) == false)
                {
                    cmbColor.Items.Add(owner.Color);
                }

                JasondDerulo.Add(owner);
            }
        }

        private void cmbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstBox1.Items.Clear();
            string color = cmbColor.SelectedItem.ToString();
            foreach (var item in JasondDerulo)
            {
                if (item.Color == color)
                {
                    lstBox1.Items.Add(item);
                }
                
            }

            MessageBox.Show(lstBox1.Items.Count.ToString());


        }
    }
}
