using ConsoleApp1;
using System.Runtime.CompilerServices;

var file = File.ReadAllLines("File.csv").Skip(1);

List<Movie> movielist = new List<Movie>();

foreach (var item in file)
{
    string[] splitlines = item.Split(",");

    Movie m = new Movie();

    m.Title = splitlines[0];

    foreach (var genre in splitlines[1].Split("/"))
    {
        genre.Replace("Comady", "Comedy");

        m.Genre.Add(genre);


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

    m.URL = splitlines[4];
    movielist.Add(m);
}

foreach (var thing in movielist)
{
    Console.WriteLine(thing);
}
