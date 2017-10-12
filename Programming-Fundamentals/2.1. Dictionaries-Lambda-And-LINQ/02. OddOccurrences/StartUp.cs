using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToList();
            var result = new Dictionary<string, int>();

            foreach (var word in input)
                if (result.ContainsKey(word))
                    result[word]++;
                else
                    result.Add(word, 1);
            var list = new List<string>();
            foreach (var word in result)
                if (word.Value % 2 != 0)
                    list.Add(word.Key);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}