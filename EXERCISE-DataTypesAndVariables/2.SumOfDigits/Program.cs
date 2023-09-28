/* silly template */

// initialize inputs defined by problem

// parse inputs from console
int number = int.Parse(Console.ReadLine());
int numberLength = (int)Math.Floor(Math.Log10(number) + 1);;
int sum = 0;
int lastNum = 0;

// preform needed operation and print out result
for (int i = 0; i < numberLength; i++)
{
    lastNum = number / (int)Math.Pow(10, i) % 10;
    sum += lastNum;
}

Console.WriteLine(sum);

Environment.Exit(0);