using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 0;
            int position = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    position = nums[i];
                }
            }
            Console.WriteLine(position);
        }
    }
}
