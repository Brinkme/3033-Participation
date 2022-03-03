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

namespace CSV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SaleData> saledata = new List<SaleData>();
        public MainWindow()
        {
            InitializeComponent();
            string[] linesoffile = File.ReadAllLines("SalesJan2009.csv");

            for (int i = 1; i < linesoffile.Length; i++)
            {
                SaleData data = new SaleData();
                string[] pieces = linesoffile[i].Split(',');
                data.Product = pieces[1];
                data.Price = Convert.ToDouble(pieces[2]);
                data.Payment_Type = pieces[3];
                data.Name = pieces[4];
                data.City = pieces[5];
                data.Country = pieces[6];
                data.State = pieces[7];
                data.Account_Created = pieces[8];
                data.Last_Login = pieces[9];
                data.Latitude = pieces[10];
                data.Longitude = pieces[11];

                lstBox.Items.Add(data);
                if (cmbBox.Items.Contains(data.Payment_Type) == false)
                {
                cmbBox.Items.Add(data.Payment_Type);
                }
                saledata.Add(data);
                
            }
        }

        private void cmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string thing = cmbBox.SelectedItem.ToString();
            lstBox.Items.Clear();

            foreach (var item in saledata)
            {
                if (thing == item.Payment_Type)
                {
                    lstBox.Items.Add(item);
                }
            }
        }
    }
}
