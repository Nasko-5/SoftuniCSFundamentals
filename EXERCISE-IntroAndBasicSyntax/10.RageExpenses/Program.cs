/* silly template */

/*
23
12.50
21.50
40
200

 */

// initialize inputs defined by problem
double lostGames = 0;
double headsetPrice = 0;
double mousePrice = 0;
double keyboardPrice = 0;
double displayPrice = 0;

try
{
    // parse inputs from console
    lostGames = double.Parse(Console.ReadLine());
    headsetPrice = double.Parse(Console.ReadLine());
    mousePrice = double.Parse(Console.ReadLine());
    keyboardPrice = double.Parse(Console.ReadLine());
    displayPrice = double.Parse(Console.ReadLine());
}
catch { Console.Error.WriteLine("Bad inputs! :("); Environment.Exit(1); }

// preform needed operation and print out result

short brokenHeadsets = 0;
short brokenMouses = 0;
short brokenKeyboards = 0;
short brokenDisplays = 0;

for (short game = 1; game <= lostGames; game++)
{
    if (game % 2 == 0)
    {
        brokenHeadsets++;
    }
    if (game % 3 == 0)
    {
        brokenMouses++;
    }
    if (game % 6 == 0)
    {
        brokenKeyboards++;
        if (brokenKeyboards % 2 == 0)
        {
            brokenDisplays++;
        }
    }
}

double total = (brokenHeadsets * headsetPrice) +
               (brokenMouses * mousePrice) +
               (brokenKeyboards * keyboardPrice) +
               (brokenDisplays * displayPrice);

Console.WriteLine($"Rage expenses: {total:F2} lv.");

Environment.Exit(0);