using System;
using System.Linq;

namespace _11.EqualSums
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }
                for (int p = i - 1; p >= 0; p--)
                {
                    leftSum += nums[p];
                }
                
                if (leftSum == rightSum)
                {
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }
            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
