namespace _5.DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine
            (
                $"{string.Join("", input.Where(c => char.IsDigit(c)).ToArray())}\n" +
                $"{string.Join("", input.Where(c => char.IsLetter(c)).ToArray())}\n" +
                $"{string.Join("", input.Where(c => !char.IsLetter(c) && !char.IsDigit(c)).ToArray())}"
            );
        }
    }
}