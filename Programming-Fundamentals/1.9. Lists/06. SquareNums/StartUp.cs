using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Sqrt(nums[i]) == (int) Math.Sqrt(nums[i]))
                {
                    newNums.Add(nums[i]);
                }
            }
            newNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", newNums));
        }
    }
}