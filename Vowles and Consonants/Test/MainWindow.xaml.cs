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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {

            lstVow.Items.Clear();
            lstCon.Items.Clear();

            string answer = txtWord.Text.ToLower();

            foreach (char item in answer)
            {
                char letter = item;

                if (char.IsLetter(letter) == true)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'i' || letter == 'u')
                    {
                        lstVow.Items.Add(letter);
                    }
                    else
                    {
                        lstCon.Items.Add(letter);
                    }
                }
            }

        }



    }
}
