/* silly template */

// initialize inputs defined by problem

// parse inputs from console
byte startChar = byte.Parse(Console.ReadLine());
byte endChar = byte.Parse(Console.ReadLine());

// preform needed operation and print out result
for (byte i = startChar; i <= endChar; i++)
{
    Console.Write($"{(char)i} ");
}

Environment.Exit(0);