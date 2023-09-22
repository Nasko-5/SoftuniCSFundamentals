/* silly template */

// initialize inputs defined by problem
int n = 1;

try
{
    // parse inputs from console
    while (n % 2 != 0)
    {
        n = int.Parse(Console.ReadLine());
        if (n % 2 != 0)
        {
            Console.WriteLine("Please write an even number.");
        }
    }
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
Console.WriteLine($"The number is: {Math.Abs(n)}");

Environment.Exit(0);