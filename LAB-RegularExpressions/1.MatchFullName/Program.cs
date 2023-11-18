using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            Regex nameRegex = new("\\b[A-Z][a-z]+ [A-Z][a-z]+\\b");

            string[] matchedNames = nameRegex.Matches(names)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

            Console.WriteLine(string.Join(' ', matchedNames));

        }
    }
}