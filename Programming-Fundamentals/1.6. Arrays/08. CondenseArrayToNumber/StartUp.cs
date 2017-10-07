using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (nums.Length > 2)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }
            if (nums.Length == 1) Console.WriteLine(nums[0]);
            else Console.WriteLine(nums[0] + nums[1]);
        }
    }
}
