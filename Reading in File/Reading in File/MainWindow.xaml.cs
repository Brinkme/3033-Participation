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
        List<SalesDataItem> datas = new List<SalesDataItem>();
        public MainWindow()
        {
            InitializeComponent();
            cmbCard.SelectedIndex = 0;

            string[] linesoffile = File.ReadAllLines("SalesJan2009.csv");

            for (int i = 1; i < linesoffile.Length; i++)
            {
                // Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
                //     0                  1    2     3             4   5    6      7         8              9          10      11

                string[] piece = linesoffile[i].Split(',');
                DateTime temp;
                SalesDataItem item = new SalesDataItem();

                if (DateTime.TryParse(piece[0], out temp))
                {
                    item.Transaction_Date = temp;   
                }
                item.Product = piece[1].Trim();
                item.Price = Convert.ToDouble(piece[2]);
                item.Payment_Type = piece[3].Trim();
                item.Name = piece[4].Trim();
                item.City = piece[5].Trim();
                item.State = piece[6].Trim();
                item.Country = piece[7].Trim();
                item.Account_Created = piece[8].Trim();
                item.Last_Login = piece[9].Trim();
                item.Latitude = piece[10].Trim();
                item.Longitude = piece[11].Trim();

                if (cmbCard.Items.Contains(item.Payment_Type) == false)
                {
                    cmbCard.Items.Add(item.Payment_Type);
                }

                lstBoxSalesData.Items.Add(item);
                datas.Add(item);  
            }
        }

        private void cmbCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string payment = cmbCard.SelectedItem.ToString();
            lstBoxSalesData.Items.Clear();

            foreach (var item in datas)
            {
                if (item.Payment_Type == payment)
                {
                    lstBoxSalesData.Items.Add(item);
                }
            }
        }
    }
}
