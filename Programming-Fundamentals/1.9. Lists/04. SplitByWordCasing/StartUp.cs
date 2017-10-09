using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {']', '[', '/', '\\', '"', ',', ';', ':', '.', '!', '(', ')', ' ', '\'', '\"'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase= new List<string>();
            int countLowerCase = 0;
            int countUpperCase = 0;

            for (int i = 0; i < input.Count; i++)
            {
                foreach (var letter in input[i])
                {
                    if ((int) letter > 64 && (int) letter < 91)
                    {
                        countUpperCase++;
                    }
                    else if ((int) letter > 96 && (int) letter < 123)
                    {
                        countLowerCase++;
                    }
                }
                if (countLowerCase == input[i].Length) lowerCase.Add(input[i]);
                else if (countUpperCase == input[i].Length) upperCase.Add(input[i]);
                else mixCase.Add(input[i]);
                countLowerCase = 0;
                countUpperCase = 0;
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
