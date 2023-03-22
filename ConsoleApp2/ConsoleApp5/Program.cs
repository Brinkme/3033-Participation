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