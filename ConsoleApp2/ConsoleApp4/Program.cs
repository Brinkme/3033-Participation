List<string> thingys = new List<string>();

do
{
    Console.WriteLine("What color of shirts do your students wear? >>");
    thingys.Add(Console.ReadLine().ToLower());


    Console.WriteLine("Do you have more students you would like to add? Yes or No");

} while (Console.ReadLine().ToLower()[0] == 'y');

double red = 0;
double cream = 0;
double blue = 0;

foreach (var item in thingys)
{
    if (item.Contains("red"))
    {
        red++;
    }
    else if (item.Contains("cream"))
    {
        cream++;
    }
    else if (item.Contains("blue"))
    {
        blue++;
    }
    else
    {
        Console.WriteLine("Sorry we don't count anything that isn't blue, red or cream now go fuck off");
    }
}
Console.WriteLine($"You have {thingys.Count} students");
Console.WriteLine($"You have {red} red number of shirts");
Console.WriteLine($"You have {cream} cream number of shirts");
Console.WriteLine($"You have {blue} blue number of shirts");
