using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.AnonymousVox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.*)(\1)";

            StringBuilder text = new StringBuilder(Console.ReadLine());

            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = Regex.Matches(text.ToString(), pattern);

            int matchesCount = 1;

            foreach (Match match in matches)
            {
                StringBuilder result = new StringBuilder();
                string toReplace = placeholders[matchesCount - 1];
                matchesCount++;

                result.Append(match.Groups[1]);
                result.Append(toReplace);
                result.Append(match.Groups[3]);

                text = text.Replace(match.Value, result.ToString());
            }
            Console.WriteLine(text);
        }
    }
}
