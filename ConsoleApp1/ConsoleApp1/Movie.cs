using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie
    {
        public string Title { get; set; }
        public List<string> Genre { get; set; }
        public List<Director> Director { get; set; }

        public List<string> Actors { get; set; }

        public string URL { get; set; }

        public Movie()
        {
            Title = string.Empty;
            Genre = new List<string>();
            Director = new List<Director>();
            Actors = new List<string>();
            URL = string.Empty;
        }

        public override string ToString()
        {
            string listOfActors = string.Join(", ", Actors);
           string listOfDirectors = string.Join(", ", Director);
            string listOfGenre = string.Join("/", Genre);

            //Return whatever information you might want etc
            return $"{Title} - {listOfActors} - {listOfDirectors} - {listOfGenre}";
        }
    }

    public class Director
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PicURL { get; set; }

        public Director()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Birthday = string.Empty;
            PicURL = string.Empty;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Birthday} - {PicURL}";
        }
    }

}
