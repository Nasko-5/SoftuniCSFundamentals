/* silly template */

// initialize inputs defined by problem

using System.Xml.Linq;

double johnMoney = 0.00;
byte studentCount = 0;
double saberPrice = 0.00;
double robePrice = 0.00;
double beltPrice = 0.00;

try
{
    // parse inputs from console
    johnMoney = double.Parse(Console.ReadLine());
    studentCount = byte.Parse(Console.ReadLine());
    saberPrice = double.Parse(Console.ReadLine());
    robePrice = double.Parse(Console.ReadLine());
    beltPrice = double.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

double freeBelts = studentCount / 6;
double beltCount = studentCount - freeBelts;
double saberCount = Math.Ceiling(studentCount + (studentCount * 0.10));

double total = (beltCount * beltPrice) +
               (saberCount * saberPrice) +
               (studentCount * robePrice);

if (johnMoney >= total)
{
    Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {total - johnMoney:F2}lv more.");
}

Environment.Exit(0);