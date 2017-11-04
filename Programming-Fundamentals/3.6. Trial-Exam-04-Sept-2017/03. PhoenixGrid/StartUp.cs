using System;
using System.Text.RegularExpressions;

namespace _03.PhoenixGrid
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var pattern = @"^([^\s_]{3}\.)+([^\s_]{3})*$";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "ReadMe") break;

                var reversed = ReverseString(input);
                var match = Regex.Match(input, pattern);

                if (input.Length == 3)
                    if (input == reversed)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");

                else if (match.Success)
                    if (input == reversed)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                else
                    Console.WriteLine("NO");
            }
        }

        public static string ReverseString(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}