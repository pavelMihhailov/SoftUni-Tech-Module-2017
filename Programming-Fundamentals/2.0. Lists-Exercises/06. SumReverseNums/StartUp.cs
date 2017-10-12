using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReverseNums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                int reverse = 0;
                while (nums[i] > 0)
                {
                    reverse = reverse * 10 + nums[i] % 10;
                    nums[i] /= 10;
                }
                sum += reverse;
            }
            Console.WriteLine(sum);
        }
    }
}
