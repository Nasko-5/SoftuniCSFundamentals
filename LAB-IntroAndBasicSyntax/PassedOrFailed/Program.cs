// initialize inputs defined by problem
float grade;

try
{
    // parse inputs from console
    grade = float.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :(");  Environment.Exit(1); }

// preform needed operation and print out result

if (grade >= 3.00)
{
    Console.WriteLine("Passed!");
} else {
    Console.WriteLine("Failed!");
}

Environment.Exit(0);