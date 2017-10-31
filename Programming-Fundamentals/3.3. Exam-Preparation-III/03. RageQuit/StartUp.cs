using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class StartUp
    {
        static void Main()
        {
            string pattern = @"([\D]+)(\d+)";
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    result.Append(match.Groups[1].ToString().ToUpper());
                }
            }
            int count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}
