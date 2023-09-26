/* silly template */

// initialize inputs defined by problem

double pounds = 0;

try
{
    // parse inputs from console
    pounds = double.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

Console.WriteLine($"{pounds * 1.31:F3}");


Environment.Exit(0);