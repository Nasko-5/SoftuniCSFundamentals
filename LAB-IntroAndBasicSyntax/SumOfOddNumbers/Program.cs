/* silly template */

// initialize inputs defined by problem
using System.ComponentModel;
using System.Diagnostics.Metrics;

int n = 0;

try
{
    // parse inputs from console
    n = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

int sum = 0;
int oddNumber = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(oddNumber);
    sum += oddNumber;
    oddNumber += 2;
}

Console.WriteLine($"Sum: {sum}");

Environment.Exit(0);