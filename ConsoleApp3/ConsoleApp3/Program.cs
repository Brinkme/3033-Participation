Console.WriteLine("What is your favorite food? >>");
string answer = Console.ReadLine().ToLower();

if (answer.Contains("steak"))
{
    string answer1 = answer.Replace("steak", "SALAD");
    Console.WriteLine(answer1);
}
else
{
    Console.WriteLine("Nice food choice");
}


List<double> things = new List<double>();
do
{
    Console.WriteLine("How old is your pet? >>");
    things.Add(Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine("Do you have another pet to add? >>");
} while (Console.ReadLine().ToLower()[0] == 'y');

Console.WriteLine($"You have {things.Count} pets");

double max = things[0];

foreach (var item in things)
{
    if (item > max)
    {
        max = item;
    }
}

Console.WriteLine($"Your oldest pets is {max} years old");