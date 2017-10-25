using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection result = Regex.Matches(text, regex);

            foreach (Match match in result)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
