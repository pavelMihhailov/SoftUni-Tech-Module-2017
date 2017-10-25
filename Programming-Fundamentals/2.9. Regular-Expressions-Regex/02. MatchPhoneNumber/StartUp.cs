using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);
            var result = matches.Cast<Match>().Select(p => p.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
