// input and parsing

double[] numberArray = Console.ReadLine()
                        .Split()
                        .Select(double.Parse)
                        .ToArray();
double[] roundedArray = numberArray
                        .Select(f => Math.Round(f, MidpointRounding.AwayFromZero))
                        .ToArray();

foreach (var tuple in numberArray.Zip(roundedArray))
{
    Console.WriteLine($"{tuple.First} => {tuple.Second}");
}