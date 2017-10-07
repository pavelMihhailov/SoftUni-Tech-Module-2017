using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Count];


            for (int i = 0; i < rotations; i++)
            {
                nums.Insert(0, nums[nums.Count - 1]);
                nums.RemoveAt(nums.Count - 1);
                for (int j = 0; j < nums.Count; j++)
                {
                    sum[j] += nums[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
