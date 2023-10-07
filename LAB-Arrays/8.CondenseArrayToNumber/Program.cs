using System.Globalization;

int[] numArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] condensed = new int[numArray.Length - 1];


if (numArray.Length == 1 )
{
    Console.WriteLine(numArray[0]);
    return;
}

for (int iteration = 0; iteration < numArray.Length; iteration++)
{

    for (int index = 0; index < condensed.Length - iteration; index++)
    {
        condensed[index] = numArray[index] + numArray[index + 1];
    }
    numArray = condensed;
}

Console.WriteLine(condensed[0]);