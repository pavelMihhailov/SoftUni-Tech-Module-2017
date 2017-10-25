using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+\.?(\d+)?($|(?=\s))";
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match number in matches)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
