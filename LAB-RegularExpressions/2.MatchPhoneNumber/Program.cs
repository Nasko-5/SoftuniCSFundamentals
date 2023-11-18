using System.Text.RegularExpressions;

namespace _2.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \+359(-| )\d\1\d{3}\1\d{4}

            string phoneNumbers = Console.ReadLine();

            Regex phoneRegex = new(@"\+359([- ])2\1\d{3}\1\d{4}\b");

            string[] phoneMatches = phoneRegex.Matches(phoneNumbers)
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", phoneMatches));


        }
    }
}