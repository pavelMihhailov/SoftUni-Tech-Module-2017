using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var newNums = new List<int>();
            for (var i = 0; i < nums.Count; i++)
                if (nums[i] >= 0)
                    newNums.Add(nums[i]);
            newNums.Reverse();
            if (newNums.Count <= 0)
                Console.WriteLine("empty");
            else
                Console.WriteLine(string.Join(" ", newNums));
        }
    }
}