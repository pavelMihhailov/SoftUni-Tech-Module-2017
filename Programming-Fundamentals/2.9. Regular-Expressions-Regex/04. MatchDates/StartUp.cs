using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([.|/|-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var input = Console.ReadLine();

            MatchCollection resultCollection = Regex.Matches(input, regex);

            foreach (Match dateMatch in resultCollection)
            {
                var day = dateMatch.Groups["day"].Value;
                var month = dateMatch.Groups["month"].Value;
                var year = dateMatch.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
