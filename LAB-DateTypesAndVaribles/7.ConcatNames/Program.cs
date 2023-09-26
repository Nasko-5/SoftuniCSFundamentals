/* silly template */

// initialize inputs defined by problem

string firstName = "";
string secondName = "";
string seprator = "";

try
{
    // parse inputs from console
    firstName = Console.ReadLine();
    secondName = Console.ReadLine();
    seprator = Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

Console.WriteLine($"{firstName}{seprator}{secondName}");

Environment.Exit(0);