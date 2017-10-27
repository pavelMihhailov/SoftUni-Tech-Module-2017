using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string pattern = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9A-Za-z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
