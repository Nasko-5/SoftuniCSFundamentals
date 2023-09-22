/* silly template */

// initialize inputs defined by problem
using System.Security.Cryptography.X509Certificates;

int n = 0;

try
{
    // parse inputs from console
    n = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} X {i} = {n * i}");
}

Environment.Exit(0);