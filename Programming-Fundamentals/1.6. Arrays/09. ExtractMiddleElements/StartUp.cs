using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine("{ "+ nums[0] + " }");
            }
            else if (nums.Length % 2 == 0)
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", nums[nums.Length / 2 - 1], nums[nums.Length / 2]));
                Console.WriteLine(" }");
            }
            else
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1]));
                Console.WriteLine(" }");
            }
        }
    }
}
