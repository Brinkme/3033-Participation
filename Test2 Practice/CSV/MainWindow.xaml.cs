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

namespace CSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SaleData> data = new List<SaleData>();
        public MainWindow()
        {
            InitializeComponent();
            string[] linesoffile = File.ReadAllLines("SalesJan2009.csv");
            for(int i = 1; i < linesoffile.Length; i++)
            {
                string[] piece = linesoffile[i].Split(',');
                DateTime temp;
                SaleData saleData = new SaleData();
                if (DateTime.TryParse(piece[0], out temp))
                {
                    saleData.Transaction_date = temp;
                }
                
                saleData.Product = piece[1];
                saleData.Price = Convert.ToDouble(piece[2]);
                saleData.Payment_Type = piece[3];
                saleData.Name = piece[4];
                saleData.City = piece[5];
                saleData.State = piece[6];
                saleData.Country = piece[7];
                saleData.Account_Created = piece[8];
                saleData.Last_Login = piece[9];
                saleData.Latitude = piece[10];
                saleData.Longitude = piece[11];

                if (cmbBox.Items.Contains(saleData.Payment_Type) == false)
                {
                     cmbBox.Items.Add(saleData.Payment_Type);
                }

                lstBox.Items.Add(saleData);
                data.Add(saleData);
            }
        }

        private void cmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string thing = cmbBox.SelectedItem.ToString();
            lstBox.Items.Clear();
            foreach (var item in data)
            {
                if (item.Payment_Type == thing)
                {
                    lstBox.Items.Add(item);
                }
            }
        }
    }
}
