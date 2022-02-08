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

namespace Reading_in_File
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] linesoffile = File.ReadAllLines("SalesJan2009.csv");

            for (int i = 0; i < linesoffile.Length; i++)
            {
                // Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
                //     0                  1    2     3             4   5    6      7         8              9          10      11

                string[] piece = linesoffile[i].Split(',');
                SalesDataItem item = new SalesDataItem();
               // item.Transaction_Date = Convert.ToDateTime(piece[0]);
                item.Product = piece[1];
                item.Price = Convert.ToDouble(piece[2]);
                item.Payment = piece[3];
                item.Name = piece[4];
                item.City = piece[5];
                item.State = piece[6];
                item.Country = piece[7];
                item.Account_Created = piece[8];
                item.Last_Login = piece[9];
                item.Latitude = Convert.ToDouble( piece[10]);
                item.Longitude = Convert.ToDouble( piece[11]);

                lstBoxSalesData.Items.Add(item);
            }
        }

        private void cmbCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
