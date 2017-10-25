using System;
using System.Text.RegularExpressions;

namespace _03.MatchHexNums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
