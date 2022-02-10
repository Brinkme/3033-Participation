using System;
using System.Collections.Generic;
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

namespace Classes2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBoxMan.Clear();
            txtBoxName.Clear();
            txtBoxPrice.Clear();
            txtBoxURL.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Toy thing = new Toy();
            if (string.IsNullOrWhiteSpace(txtBoxMan.Text) == false)
            {
            thing.Manufactuer = txtBoxMan.Text;
            }
            else
            {
                MessageBox.Show("Sorry, that is invalid enter a Manufacturer");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) == false)
            {
            thing.Name = txtBoxName.Text;
            }
            else
            {
                MessageBox.Show("Sorry, that is invalid enter a Name");
                return;
            }

            if (double.TryParse(txtBoxPrice.Text, out double price) == true)
            {
                thing.Price = price;
            }
            else
            {
                MessageBox.Show("Sorry, that is invalid enter a Price");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxURL.Text) == false)
            {
            thing.Image = txtBoxURL.Text;
            }
            else
            {
                MessageBox.Show("Sorry, that is invalid enter a URL");
                return;
            }

            lstBoxAdd.Items.Add(thing);
        }

        private void lstBoxAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstBoxAdd.SelectedItem;

            //MessageBox.Show();
        }
    }
}
