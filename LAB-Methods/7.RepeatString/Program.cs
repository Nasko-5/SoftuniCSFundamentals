namespace _7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRepeat = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string repeatedString = StringRepeat(toRepeat, repeats);;

            Console.WriteLine(repeatedString);
        }

        private static string StringRepeat(string? toRepeat, int repeats)
        {
            string store = "";

            for (int i = 0; i < repeats; i++)
            {
                store += toRepeat;
            }

            return store;
        }
    }
}