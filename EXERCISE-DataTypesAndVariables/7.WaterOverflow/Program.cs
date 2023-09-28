/* silly template */

// initialize inputs defined by problem

byte lines = byte .Parse(Console.ReadLine());

short liters = 0;

byte capacity = 255;
short currentlyFilled = 0;

// parse inputs from console

for (int i = 0; i < lines; i++)
{
    liters = short.Parse(Console.ReadLine());

    if (currentlyFilled + liters >= capacity)
    {
        Console.WriteLine("Insufficient capacity!");
        continue;
    }
    currentlyFilled += liters;
}
// preform needed operation and print out result
Console.WriteLine(currentlyFilled);

Environment.Exit(0);