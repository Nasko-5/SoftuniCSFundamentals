
namespace _4.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            string text  = Console.ReadLine();

            foreach (string word in bannedWords)
                text = text.Replace(word, new string('*', word.Length));

            Console.WriteLine(text);

        }
    }
}