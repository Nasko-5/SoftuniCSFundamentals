using System.Text;

namespace _2.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string s in input)
            {
                stringBuilder.Insert(stringBuilder.Length, s, s.Length);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}