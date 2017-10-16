using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> dictionary = new SortedDictionary<string, decimal>();

            CalculatePrice(n, dictionary);

            foreach (var town in dictionary)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }

        private static void CalculatePrice(int n, SortedDictionary<string, decimal> dictionary)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string town = input[0];
                decimal price = decimal.Parse(input[2]);
                decimal quantity = decimal.Parse(input[3]);
                if (!dictionary.ContainsKey(town))
                {
                    dictionary.Add(town, 0);
                }
                dictionary[town] += price * quantity;

            }
        }
    }
}
