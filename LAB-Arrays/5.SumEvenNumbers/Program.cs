// read input and parse

int[] numbers = Console.ReadLine()
    .Split()
    .Select(i => int.Parse(i) % 2 == 0 ? int.Parse(i) : 0)
    .ToArray();

int sumOfNumbers = numbers.Sum();

Console.WriteLine(sumOfNumbers);
