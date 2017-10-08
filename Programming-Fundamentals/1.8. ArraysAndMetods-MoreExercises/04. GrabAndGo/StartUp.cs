using System;
using System.Linq;

namespace _04.GrabAndGo
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stopNum = int.Parse(Console.ReadLine());

            var lastPosition = -1;
            long sum = 0;

            for (var i = 0; i < nums.Length; i++)
                if (stopNum == nums[i])
                    lastPosition = i;
            if (lastPosition < 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (var i = 0; i < lastPosition; i++)
                    sum += nums[i];
                Console.WriteLine(sum);
            }
        }
    }
}