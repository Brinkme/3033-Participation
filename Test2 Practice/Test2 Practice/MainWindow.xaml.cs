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

namespace Test2_Practice
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
            if (string.IsNullOrWhiteSpace(txtboxCity.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for City");
            }
            if (string.IsNullOrWhiteSpace(txtboxFName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for First Name");
            }
            double gpa = 0;
            if (double.TryParse(txtboxGPA.Text, out gpa) == false)
            {
                MessageBox.Show("Sorry, please enter something valid for GPA");
            }
            if (string.IsNullOrWhiteSpace(txtboxLName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for Last Name");
            }
            if (string.IsNullOrWhiteSpace(txtboxMajor.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for Major");
            }
            if (string.IsNullOrWhiteSpace(txtboxState.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for State");
            }
            if (string.IsNullOrWhiteSpace(txtboxStreetName.Text) == true)
            {
                MessageBox.Show("Sorry, please enter something valid for Street Name");
            }
            int streetnum = 0;
            if (int.TryParse(txtboxStreetNum.Text, out streetnum) == false)
            {
                MessageBox.Show("Sorry, please enter something valid for Street Number");
            }
            int zip = 0;
            if (int.TryParse(txtboxZip.Text, out zip) == false)
            {
                MessageBox.Show("Sorry, please enter something valid for Zip Code");
            }

            Student stu = new Student();

            stu.FirstName = txtboxFName.Text;
            stu.LastName = txtboxLName.Text;
            stu.GPA = Convert.ToDouble(txtboxGPA.Text);
            stu.Major = txtboxMajor.Text;

            stu.SetAddress(streetnum, txtboxStreetName.Text, txtboxState.Text, txtboxCity.Text, zip);
            lstBox.Items.Add(stu);


        }
    }
}
