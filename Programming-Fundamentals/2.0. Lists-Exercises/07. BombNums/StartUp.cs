using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNum = commands[0];
            int bombPower = commands[1];
            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                int start = i - bombPower;
                int end = i + bombPower;
                if (start < 0) start = 0;
                if (end > nums.Count - 1) end = nums.Count - 1;

                if (nums[i] == bombNum)
                {
                    nums.RemoveRange(start, end - start + 1);
                    i--;
                }
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
