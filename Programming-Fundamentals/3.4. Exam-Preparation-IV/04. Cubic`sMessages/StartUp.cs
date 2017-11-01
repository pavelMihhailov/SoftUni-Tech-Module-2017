using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Cubic_sMessages
{
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!") break;
                int wordLength = int.Parse(Console.ReadLine());

                Match match = Regex.Match(input, @"^([0-9]+)([A-Za-z]+)([^a-zA-Z]*)$");

                List<int> indexes = new List<int>();

                string encryptedWord = match.Groups[2].Value;

                bool isValid = false;
                isValid = GetIndexesIfValid(wordLength, match, indexes, encryptedWord, isValid);

                if (isValid)
                {
                    StringBuilder result = new StringBuilder();

                    for (int i = 0; i < indexes.Count; i++)
                    {
                        if (indexes[i] > encryptedWord.Length - 1) result.Append(" ");
                        else result.Append(encryptedWord[indexes[i]]);
                    }
                    dict.Add(encryptedWord, result.ToString());
                }
            }
            foreach (var word in dict)
            {
                Console.WriteLine($"{word.Key} == {word.Value}");
            }
        }

        private static bool GetIndexesIfValid(int wordLength, Match match, List<int> indexes, string encryptedWord, bool isValid)
        {
            if (match.Success)
            {
                if (encryptedWord.Length == wordLength)
                {
                    isValid = true;

                    foreach (var index in match.Groups[1].Value)
                    {
                        if (Char.IsDigit(index)) indexes.Add(index - 48);
                    }
                    foreach (var index in match.Groups[3].Value)
                    {
                        if (Char.IsDigit(index)) indexes.Add(index - 48);
                    }
                }
            }
            return isValid;
        }
    }
}
