List<string> states = new List<string>();
List<double> letters = new List<double>();

do
{
    Console.WriteLine("Please enter a state you have lived in >>");
    states.Add(Console.ReadLine());

    Console.WriteLine("Do you have another state to add? yes or no >>");

} while (Console.ReadLine().ToLower()[0] == 'y');

int max = states[0].Length;
double lettercounter = 0;

foreach (string state in states)
{
    lettercounter = 0;
    for (int i = 0; i < state.Length; i++)
    {
        char letter = state[i];
        if (char.IsLetter(letter) == true)
        {
            lettercounter++;
            letters.Add(lettercounter);
        }
    }
    if (state.Length > max)
    {
        max = state.Length;
    }
}

foreach (var item in letters)
{
    if (item > lettercounter)
    {
        lettercounter = item;
    }
}

Console.WriteLine($"You have been to {states.Count} state(s)z");

foreach (string state in states)
{
    if (state.Length == max)
    {
        Console.WriteLine($"{state.ToUpper()} : {state[0]}{state[1]} has a length of {lettercounter}");
    }
}