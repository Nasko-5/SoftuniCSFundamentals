// initialize inputs defined by problem
string name = default;
int age = default;
float avgGrade = default;

try
{
    // parse inputs from console
    name = Console.ReadLine();
    age = int.Parse(Console.ReadLine());
    avgGrade= float.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avgGrade:F2}");

Environment.Exit(0);