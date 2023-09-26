/* silly template */

// initialize inputs defined by problem

uint centuries = 0;
try
{
    // parse inputs from console
    centuries = uint.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

uint years = centuries * 100;
uint days = (uint)(years * 365.2422);
ulong hours = days * 24;
ulong minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

Environment.Exit(0);