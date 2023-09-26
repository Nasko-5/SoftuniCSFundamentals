/* silly template */

// initialize inputs defined by problem

char character = ' ';

try
{
    // parse inputs from console
    character = char.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
if (Char.IsUpper(character))
{
    Console.WriteLine("upper-case");
} else
{
    Console.WriteLine("lower-case");
}

Environment.Exit(0);