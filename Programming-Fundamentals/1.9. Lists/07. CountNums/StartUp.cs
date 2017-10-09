using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            nums.Sort();
            decimal count = 1;
            if (nums.Count == 1) Console.WriteLine("{0} -> 1", nums[0]);
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (i == nums.Count - 1) break;
                    if (nums[i] == nums[i + 1]) count++;
                    else
                    {
                        Console.WriteLine($"{nums[i]} -> {count}");
                        count = 1;
                    }
                    if (i == nums.Count - 2 && nums[i] == nums[i + 1])
                    {
                        Console.WriteLine($"{nums[i]} -> {count}");
                    }
                    else if (i == nums.Count - 2 && nums[i] != nums[i + 1])
                    {
                        Console.WriteLine($"{nums[i + 1]} -> 1");
                    }

                }
            }

        }
    }
}
