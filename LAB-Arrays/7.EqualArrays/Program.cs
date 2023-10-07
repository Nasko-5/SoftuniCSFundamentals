int[] arrayOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] arrayTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

uint index = 0;
foreach (var tuple in arrayOne.Zip(arrayTwo))
{
    if (tuple.First != tuple.Second)
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        Environment.Exit(0);
    }

    index++;
}

int arraySum = arrayOne.Sum();
Console.WriteLine($"Arrays are identical. Sum: {arraySum}");