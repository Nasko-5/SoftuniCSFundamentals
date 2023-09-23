/* silly template */

// initialize inputs defined by problem

int rangeStart = 0;
int rangeEnd = 0;

try
{
    // parse inputs from console
    rangeStart = int.Parse(Console.ReadLine());
    rangeEnd = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

int sum = 0;

for (int i = rangeStart; i <= rangeEnd; i ++)
{
    Console.Write($"{i} ");
    sum += i;
}

Console.WriteLine($"\nSum: {sum}");

Environment.Exit(0);