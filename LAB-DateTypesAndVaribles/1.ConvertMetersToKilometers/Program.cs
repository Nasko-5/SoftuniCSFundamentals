/* silly template */

// initialize inputs defined by problem
double meters = 0;

try
{
    // parse inputs from console
    meters = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

Console.WriteLine($"{meters/1000:F2}");

Environment.Exit(0);