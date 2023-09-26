/* silly template */

using System.Data;

static char[] Reverse(string s)
{
char[] charArray = s.ToCharArray();
Array.Reverse(charArray);
return charArray;
}


// initialize inputs defined by problem

string toReverse = "";

try
{
    // parse inputs from console
    for (int i = 0; i < 3; i++ )
    {
        toReverse += Console.ReadLine();
    } 
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
char[] reversedChars = Reverse(toReverse);
string seprated = string.Join(" ", reversedChars);

Console.WriteLine(seprated);



Environment.Exit(0);