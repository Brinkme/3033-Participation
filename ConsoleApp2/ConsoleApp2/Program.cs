List<string> states = new List<string>();


do
{
    Console.WriteLine("Please enter a state you have lived in >>");
    states.Add(Console.ReadLine());

    Console.WriteLine("Do you have another state to add? yes or no >>");

} while (Console.ReadLine().ToLower() == "yes");

int max = states[0].Length;

foreach (string state in states)
{
    if (state.Length > max)
    {
        max = state.Length;
    }
}

Console.WriteLine($"You have been to {states.Count} state(s)");

foreach (string state in states)
{
    if (state.Length == max)
    {
        Console.WriteLine($"{state.ToUpper()} : {state[0].ToString().ToUpper()}{state[1].ToString().ToUpper()} and has a character length of {max}");
    }
}