/* silly template */

// initialize inputs defined by problem
float grade = default;

try
{
    // parse inputs from console
    grade = float.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
if (grade >= 3.00)
{
    Console.WriteLine("Passed!");
}

Environment.Exit(0);