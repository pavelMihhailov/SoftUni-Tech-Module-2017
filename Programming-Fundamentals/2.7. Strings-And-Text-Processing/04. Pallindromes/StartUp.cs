using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Pallindromes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {',', '!', ' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();

            foreach (var word in input)
            {
                if (isPalindrome(word)) list.Add(word);
            }
            Console.WriteLine(string.Join(", ", list.Distinct().OrderBy(w => w)));
        }

        private static bool isPalindrome(string word)
        {
            int leftIndex = 0;
            int rightIndex = word.Length - 1;

            while (rightIndex > leftIndex)
            {
                if (word[leftIndex] != word[rightIndex])
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}
