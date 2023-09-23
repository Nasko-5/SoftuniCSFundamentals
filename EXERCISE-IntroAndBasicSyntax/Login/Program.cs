/* silly template */



using System.Reflection.Metadata.Ecma335;

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// initialize inputs defined by problem
string username = " ";

try
{
    // parse inputs from console
    username = Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

string password = Reverse(username);
string passwordAttempt = "";
byte attempts = 0;


while (true)
{
    passwordAttempt = Console.ReadLine();

    if (attempts >= 3 && passwordAttempt != password)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }

    if (passwordAttempt == password)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    } else
    {
        Console.WriteLine("Incorrect password. Try again.");
    }

    attempts++;
}


Environment.Exit(0);