/* silly template */

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// initialize inputs defined by problem
string text = "";

try
{
    // parse inputs from console
    text =Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
string reversedString = Reverse(text);

Console.WriteLine(reversedString);

Environment.Exit(0);