using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNums
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var dict = new SortedDictionary<double, double>();

            foreach (var num in nums)
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 1);

            foreach (var num in dict)
                Console.WriteLine("{0} -> {1}", num.Key, num.Value);
        }
    }
}