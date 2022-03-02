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

namespace Graduation_Example
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

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a First Name");
            }
            if (string.IsNullOrWhiteSpace(txtboxLName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a Last Name");
            }
            if (string.IsNullOrWhiteSpace(txtboxMajor.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a Major");
            }
            double gpa;
            if (double.TryParse(txtboxGPA.Text, out gpa) == false)
            {
                MessageBox.Show("Sorry, please enter a GPA");
            }
            if (string.IsNullOrWhiteSpace(txtboxCity.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a City");
            }
            if (string.IsNullOrWhiteSpace(txtboxState.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a State");
            }
            if (string.IsNullOrWhiteSpace(txtboxStreetName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter a Street Name");
            }
            int streetnum;
            if (int.TryParse(txtboxStreetNum.Text,out streetnum) == false)
            {
                MessageBox.Show("Sorry, please enter a Street Number");
            }
            int zip;
            if (int.TryParse(txtboxZip.Text, out zip) == false)
            {
                MessageBox.Show("Sorry, please enter a Zipcode");
            }

            Student stu = new Student();
            stu.GPA = gpa;
            stu.LastName = txtboxLName.Text;
            stu.FirstName = txtboxFName.Text;
            stu.Major = txtboxMajor.Text;

            lstBox.Items.Add(stu);
        }
    }
}
