using System.Security.Cryptography.X509Certificates;

Dictionary<string, bool> states = new Dictionary<string, bool>();
List<double> Letters = new List<double>();

states.Add("alabama", false);
states.Add("alaska", false);
states.Add("arizona", false);
states.Add("arkansas", false);
states.Add("california", false);
states.Add("colorado", false);
states.Add("connecticut", false);
states.Add("delaware", false);
states.Add("florida", false);
states.Add("georgia", false);
states.Add("hawaii", false);
states.Add("idaho", false);
states.Add("illinois", false);
states.Add("indiana", false);
states.Add("iowa", false);
states.Add("kansas", false);
states.Add("kentucky", false);
states.Add("louisiana", false);
states.Add("maine", false);
states.Add("maryland", false);
states.Add("massachusetts", false);
states.Add("michigan", false);
states.Add("minnesota", false);
states.Add("mississippi", false);
states.Add("missouri", false);
states.Add("montana", false);
states.Add("nebraska", false);
states.Add("nevada", false);
states.Add("new hampshire", false);
states.Add("new jersey", false);
states.Add("new mexico", false);
states.Add("new york", false);
states.Add("north carolina", false);
states.Add("north dakota", false);
states.Add("ohio", false);
states.Add("oklahoma", false);
states.Add("oregon", false);
states.Add("pennsylvania", false);
states.Add("rhode island", false);
states.Add("south carolina", false);
states.Add("south dakota", false);
states.Add("tennessee", false);
states.Add("texas", false);
states.Add("utah", false);
states.Add("vermont", false);
states.Add("virginia", false);
states.Add("washington", false);
states.Add("west virginia", false);
states.Add("wisconsin", false);
states.Add("wyoming", false);

do
{
    Console.WriteLine("What state have you been to? >>");
    string answer = Console.ReadLine().ToLower();

    if (states.ContainsKey(answer) == false)
    {
        Console.WriteLine("Sorry invalid state try again. >>");
        answer = Console.ReadLine().ToLower();
        if (states.ContainsKey(answer))
        {
            states[answer] = true;
        }
    }
    else if (states.ContainsKey(answer))
    {
        states[answer] = true;
    }

    Console.WriteLine("Do you have another state to add? >>");
   
} while (Console.ReadLine().ToLower()[0] == 'y');

string max = string.Empty;
double lettercounter = 0;

foreach (var item in states)
{
    if (item.Value == true)
    {
        lettercounter = 0;
        for (int i = 0; i < item.Key.Length; i++)
        {
            char letter = item.Key[i];
            if (char.IsLetter(letter) == true)
            {
                lettercounter++;
                Letters.Add(lettercounter);
            }
        }
        if (lettercounter > max.Length)
        {
            max = item.Key;
        }
    }
}

foreach (var item in Letters)
{
    if (item > lettercounter)
    {
        lettercounter = item;
    }
}

Console.WriteLine($"\nYou have been to {states.Where(x => x.Value==true).ToList().Count} state(s)");
Console.WriteLine($"\nYou have not been to {states.Where(x => x.Value == false).ToList().Count} state(s)");
Console.WriteLine($"\nThe longest character state that you have been to is {max.ToUpper()} and has {lettercounter} of characters long!");