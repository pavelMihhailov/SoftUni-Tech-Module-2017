using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string theWord = Console.ReadLine();
            string regex = @"[\!\.\?]";
            string[] input = Regex.Split(Console.ReadLine(), regex);

            foreach (var sentence in input)
            {
                string[] words = Regex.Split(sentence, @"\W");
                if (words.Contains(theWord))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
