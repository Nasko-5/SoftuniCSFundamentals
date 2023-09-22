/* silly template */

// initialize inputs defined by problem
int hours = default;
int minutes = default;

try
{
    // parse inputs from console
    hours = int.Parse(Console.ReadLine());
    minutes = int.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

int seconds = (hours * 3600) + (minutes * 60);
seconds += 1800;

// int adjustedHours = (seconds / 3600) % 24;
// int adjustedMinutes = ((seconds - (adjustedHours * 3600)) / 60) % 59;

int adjustedHours = (seconds / 3600) % 24;
int adjustedMinutes = (seconds / 60) % 60;

Console.WriteLine($"{adjustedHours}:{adjustedMinutes:D2}");


Environment.Exit(0);
