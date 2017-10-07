using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Max(nums[i], nums[j]) - Math.Min(nums[i], nums[j]) == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
