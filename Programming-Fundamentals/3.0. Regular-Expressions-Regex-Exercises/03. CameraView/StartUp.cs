using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToSkip = elements[0];
            int elementsToTake = elements[1];

            string input = Console.ReadLine();

            string pattern = @"\|<(\w{" + elementsToSkip + @"})(\w{0," + elementsToTake + "})";

            MatchCollection result = Regex.Matches(input, pattern);

            List<string> resultList = new List<string>();

            foreach (Match match in result)
            {
                resultList.Add(match.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
