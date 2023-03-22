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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var file = File.ReadAllLines("File.csv").Skip(1);

            List<Movie> movielist = new List<Movie>();

            foreach (var item in file)
            {
                string[] splitlines = item.Split(",");

                Movie m = new Movie();

                m.Title = splitlines[0];

                foreach (var genre in splitlines[1].Split("/"))
                {
                    if (cmbGenere.Items.Contains(genre) == false)
                    {
                        cmbGenere.Items.Add(genre);
                    }
                }

                foreach (var director in splitlines[2].Split(";"))
                {
                    Director d = new Director();

                    var pieces = director.Split("|");

                    d.FirstName = pieces[0];
                    d.LastName = pieces[1];
                    d.Birthday = pieces[2];
                    d.PicURL = pieces[3];

                    m.Director.Add(d);
                }

                foreach (var actor in splitlines[3].Split(";"))
                {
                    m.Actors.Add(actor);
                }

                movielist.Add(m);
            }

            foreach (var thing in movielist)
            {
                Console.WriteLine(thing);
            }

        }
    }
}
