using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_A_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var replacement = @"[URL href=$1]$2[/URL]";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                string replaced = Regex.Replace(input, regex, replacement);
                Console.WriteLine(replaced);
            }
        }
    }
}
