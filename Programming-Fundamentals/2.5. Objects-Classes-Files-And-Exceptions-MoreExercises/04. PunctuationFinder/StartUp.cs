using System;
using System.Collections.Generic;
using System.IO;

namespace _04.PunctuationFinder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");
            var newText = new List<char>();

            char[] puncts = { '.', ',', '?', '!', ':' };
            foreach (var word in text)
            {
                foreach (var letter in word.ToString())
                {
                    for (int i = 0; i < puncts.Length; i++)
                    {
                        if (letter == puncts[i])
                        {
                            newText.Add(letter);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", newText));
        }
    }
}
