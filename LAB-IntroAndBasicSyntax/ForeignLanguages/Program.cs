/* silly template */

// initialize inputs defined by problem
string country = default;

try
{
    // parse inputs from console
    country = Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

switch (country)
{
    case "USA" or "England":
        Console.WriteLine("English");
        break;
    case "Spain" or "Argentina" or "Mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}


Environment.Exit(0);