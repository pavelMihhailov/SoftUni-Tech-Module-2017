using System;
using System.Linq;

namespace _03.FoldSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] result = new int[2 * k];

            int[] leftSide = nums.Take(k).Reverse().ToArray();
            int[] rightSide = nums.Skip(3 * k).Take(k).Reverse().ToArray();
            int[] midSide = nums.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < k; i++)
            {
                result[i] = leftSide[i];
            }
            for (int i = k; i < 2 * k; i++)
            {
                result[i] = rightSide[i - k];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                result[i] += midSide[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
