using System.Text.RegularExpressions;

namespace _3.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b

            string dates = Console.ReadLine();

            Regex dateRegex = new(@"\b(?<day>\d{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");

            MatchCollection matchedDates = dateRegex.Matches(dates);

            foreach (Match date in matchedDates)
            {
                Console.WriteLine(
                    $"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}