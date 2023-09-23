/* silly template */

// initialize inputs defined by problem
using System.Security.Cryptography;

int peopleCount = 0;
string groupType = "";
string dayOfWeek = "";

double[,] priceTable =
{
    {8.45,  9.80,  10.46},

    {10.90, 15.60, 16   },

    {15,    20,    22.50},
};

try
{
    // parse inputs from console
    peopleCount = int.Parse(Console.ReadLine());
    groupType = Console.ReadLine();
    dayOfWeek = Console.ReadLine();
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result
byte groupTypeIndex = 0;
byte dayOfWeekIndex = 0;

switch (groupType)
{
    case "Students":
        groupTypeIndex = 0;
        break;
    case "Business":
        groupTypeIndex = 1;
        break;
    case "Regular":
        groupTypeIndex = 2;
        break;
}

switch (dayOfWeek)
{
    case "Friday":
        dayOfWeekIndex = 0;
        break;
    case "Saturday":
        dayOfWeekIndex = 1;
        break;
    case "Sunday":
        dayOfWeekIndex = 2;
        break;
}

double priceForOnePerson = priceTable[groupTypeIndex, dayOfWeekIndex];
double total = 0;


if (groupType == "Students" && peopleCount >= 30)
{
    total = priceForOnePerson * peopleCount;
    total -= total * 0.15;
} else if (groupType == "Business" && peopleCount >= 100)
{
    peopleCount -= 10;
    total = priceForOnePerson * peopleCount;
} else if (groupType == "Regular" && (peopleCount >= 10 && peopleCount <= 20))
{
    total = priceForOnePerson * peopleCount;
    total -= total * 0.05;
} else
{
    total = priceForOnePerson * peopleCount;
}

Console.WriteLine($"Total price: {total:F2}");

Environment.Exit(0);