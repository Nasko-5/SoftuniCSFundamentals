/* silly template */

// initialize inputs defined by problem
string dayType = default;
int age = default;

int[,] priceTable =
{
    {12,18,12},
    {15,20,15},
    {5,12,10}
};

try
{
    // parse inputs from console
    dayType = Console.ReadLine();
    age = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

int dayTypeIndex, ageIndex;

switch (dayType)
{
    case "Weekday":
        dayTypeIndex = 0;
        break;
    case "Weekend":
        dayTypeIndex = 1; 
        break;
    case "Holiday":
        dayTypeIndex = 2;
        break;
    default:
        dayTypeIndex = 0;
        Console.WriteLine("Error!");
        Environment.Exit(0);
        break;
}

switch (age)
{
    case >= 0 and <= 18:
        ageIndex = 0;
        break;
    case > 18 and <= 64:
        ageIndex = 1;
        break;
    case > 64 and <= 122:
        ageIndex = 2;
        break;
    default:
        ageIndex = 0;
        Console.WriteLine("Error!");
        Environment.Exit(0);
        break;
}

int price = priceTable[dayTypeIndex, ageIndex];
Console.WriteLine($"{price}$");

Environment.Exit(0);