/* silly template */

// initialize inputs defined by problem

string fullString = "";

try
{
    // parse inputs from console
    for (int i = 0; i < 3; i++)
    {
        fullString += char.Parse(Console.ReadLine());
    }
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

Console.WriteLine(fullString);

Environment.Exit(0);