namespace _5.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(a => a < 0);
            numbers.Reverse();

            Console.WriteLine(numbers.Count != 0 ? string.Join(' ', numbers) : "empty");
        }
    }
}