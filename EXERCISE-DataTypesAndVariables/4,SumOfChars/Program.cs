/* silly template */

// initialize inputs defined by problem


// parse inputs from console

int numberOfLines = int .Parse(Console.ReadLine());
int sum = 0;
char letter = ' ';

// preform needed operation and print out result
for (int i = 0; i < numberOfLines; i++)
{
    letter = char.Parse(Console.ReadLine());
    sum += letter;
}

Console.WriteLine($"The sum equals: {sum}");

Environment.Exit(0);