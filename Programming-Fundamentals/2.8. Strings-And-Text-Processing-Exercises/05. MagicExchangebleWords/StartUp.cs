using System;
using System.Linq;

namespace _05.MagicExchangebleWords
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var firstWord = input[0].Distinct().ToArray();
            var secondWord = input[1].Distinct().ToArray();

            if (firstWord.Length == secondWord.Length)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}