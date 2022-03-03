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
                string[] pieces = linesoffile[i].Split(',');
                SaleData saledate = new SaleData();

                saledate.Product = pieces[1];
                saledate.Price = Convert.ToDouble(pieces[2]);
                saledate.Payment_Type = pieces[3];
                saledate.Name = pieces[4];
                saledate.City = pieces[5];
                saledate.State = pieces[6];
                saledate.Country = pieces[7];
                saledate.Account_Created = pieces[8];
                saledate.Last_Login = pieces[9];
                saledate.Latitude = pieces[10];
                saledate.Longitude = pieces[11];

                lstBox.Items.Add(saledate);
                if (cmbBox.Items.Contains(saledate.Payment_Type) == false)
                {
                cmbBox.Items.Add(saledate.Payment_Type);
                }
                saledata.Add(saledate);
            }

        }

        private void cmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string thing = cmbBox.SelectedItem.ToString();
            lstBox.Items.Clear();

            foreach (var item in saledata)
            {
                if (item.Payment_Type == thing)
                {
                    lstBox.Items.Add(item);
                }
            }


        }
    }
}
