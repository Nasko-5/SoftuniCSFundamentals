namespace _1.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().Replace(" ", "");

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (!letterCount.ContainsKey(c))
                {
                    letterCount[c] = 1;
                } else
                {
                    letterCount[c]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in letterCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}