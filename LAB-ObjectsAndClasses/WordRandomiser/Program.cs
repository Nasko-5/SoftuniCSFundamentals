namespace WordRandomiser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int value = random.Next(words.Count);
                Console.Write($"{words[value]} ");
            }
        }
    }
}