/* silly template */

// initialize inputs defined by problem
int n = 0;

try
{
    // parse inputs from console
    n = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

if (n % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}

else if (n % 2 == 0 && n % 3 == 0 && n % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
} 

else if (n % 2 == 0 && n % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
} 

else if (n % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
} 

else if (n % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
} 

else if (n % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
} 

else if (n % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
} 

else
{
    Console.WriteLine("Not divisible");
}

Environment.Exit(0);