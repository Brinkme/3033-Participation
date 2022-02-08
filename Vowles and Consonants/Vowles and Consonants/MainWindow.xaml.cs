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

namespace Vowles_and_Consonants
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            lstVowles.Items.Clear();
            lstCon.Items.Clear();

            string answer = txtWord.Text.ToLower();

            for (int i = 0; i < answer.Length; i++)
            {
                char letter = answer[i];
                if (char.IsLetter(letter) == true)
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        lstVowles.Items.Add(letter);
                    }
                    else
                    {
                        lstCon.Items.Add(letter);
                    }

                }
            }

            txtWord.Clear();
        }

        private void lstVowles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
