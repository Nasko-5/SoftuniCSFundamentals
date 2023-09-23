/* silly template */

// initialize inputs defined by problem
int age = 0;

try
{
    // parse inputs from console
    age = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

string title = "";

switch (age)
{
    case >= 0 and <= 2:
        title = "baby";
        break;
    case >= 3 and <= 13:
        title = "child";
        break;
    case >= 14 and <= 19:
        title = "teenager";
        break;
    case >= 20 and <= 65:
        title = "adult";
        break;
    case >= 66:
        title = "elder";
        break;
}

Console.WriteLine(title);

Environment.Exit(0);