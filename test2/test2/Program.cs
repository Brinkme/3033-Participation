// See https://aka.ms/new-console-template for more information
Console.WriteLine("Are you Connor");
string answer;
answer = Console.ReadLine().ToLower();
if (answer[0] == 'y' )
{
    Console.WriteLine("Fuck you!");
}
else
{
    Console.WriteLine("What is your name?");
    answer = Console.ReadLine();

    Console.WriteLine($"Well, {answer} fuck you!");
}
