using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RegexMon
{
    class StartUp
    {
        static void Main()
        {
            string bojoMonMatch = @"[A-Za-z]+-[A-Za-z]+";
            string didiMonMatch = @"[^A-Za-z\-]+";

            string input = Console.ReadLine();
            StringBuilder mainInput = new StringBuilder();
            mainInput.Append(input);

            int turn = 0;

            while (mainInput.Length > 0)
            {
                Match bojoMatch = Regex.Match(mainInput.ToString(), bojoMonMatch);
                Match didiMatch = Regex.Match(mainInput.ToString(), didiMonMatch);

                turn++;

                if (didiMatch.Success && turn % 2 != 0)
                {
                    mainInput.Remove(0, didiMatch.Index + didiMatch.Length);
                    Console.WriteLine(didiMatch.Value);
                }
                else if (!didiMatch.Success && turn % 2 != 0) break;

                else if (bojoMatch.Success && turn % 2 == 0)
                {
                    mainInput.Remove(0, bojoMatch.Index + bojoMatch.Length);
                    Console.WriteLine(bojoMatch.Value);
                }
                else if (!bojoMatch.Success && turn % 2 == 0) break;
            }
        }
    }
}
