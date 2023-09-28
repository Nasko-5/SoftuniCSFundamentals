/* silly template */

// initialize inputs defined by problem

int number = int .Parse(Console.ReadLine());
char firstChar, secondChar, thirdChar;

// parse inputs from console

for (int i = 0; i < number; i++)
{
	firstChar = (char)('a' + i);
	for (int j = 0; j < number; j++)
	{
        secondChar = (char)('a' + j);
        for (int k = 0; k < number; k++)
		{
            thirdChar = (char)('a' + k);
            Console.Write(firstChar);
            Console.Write(secondChar);
            Console.Write(thirdChar);
            Console.WriteLine();
        }
    }
}

// preform needed operation and print out result


Environment.Exit(0);