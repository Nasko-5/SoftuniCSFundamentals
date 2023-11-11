using System.ComponentModel;

namespace _3.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string input = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;

            while (input.Contains(toRemove))
            {
                startIndex = input.IndexOf(toRemove);
                endIndex =  toRemove.Length;
                input = input.Remove(startIndex, endIndex);
            }

            Console.WriteLine(input);
        }
    }
}