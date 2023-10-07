int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenSum = numbers.Select(i => i % 2 == 0 ? i : 0).ToArray().Sum();
int oddSum = numbers.Select(i => i % 2 != 0 ? i : 0).ToArray().Sum();
int difference = evenSum - oddSum;
Console.WriteLine(difference);