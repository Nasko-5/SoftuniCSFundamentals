/* silly template */

// initialize inputs defined by problem
decimal n = 0;
decimal total = 0;
int numbers = 0;

try
{
    // parse inputs from console
    numbers = int.Parse(Console.ReadLine());
    while (1 <= numbers)
    {
        n = decimal.Parse(Console.ReadLine());
        total += n;
        numbers--;
    }
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
Console.WriteLine(total);

Environment.Exit(0);