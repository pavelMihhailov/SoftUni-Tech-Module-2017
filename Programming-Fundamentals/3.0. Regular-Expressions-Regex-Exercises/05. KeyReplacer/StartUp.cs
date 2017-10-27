using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = @"^(?<startKey>[a-zA-Z]*)([<\|\\])(?<words>.*)([<\|\\])(?<endKey>[a-zA-z]*)$";

            var tryKey = Regex.Match(keys, pattern);
            StringBuilder result = new StringBuilder();

            if (tryKey.Success)
            {
                string startKey = tryKey.Groups["startKey"].Value;
                string endKey = tryKey.Groups["endKey"].Value;

                MatchCollection matches = Regex.Matches(input, $@"{startKey}(?<words>.*?){endKey}");

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["words"].Value);
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
