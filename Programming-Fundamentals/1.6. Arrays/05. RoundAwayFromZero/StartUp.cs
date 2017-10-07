using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundAwayFromZero
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] nums = input.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double edited = Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(nums[i] + " => " + edited);
            }
        }
    }
}
