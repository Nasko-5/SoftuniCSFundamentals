/* silly template */

// initialize inputs defined by problem
int rows = 1;

try
{
    // parse inputs from console
    rows = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

for (int row = 1; row <= rows; row++)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write($"{row} ");
    }
    Console.WriteLine();
}

Environment.Exit(0);