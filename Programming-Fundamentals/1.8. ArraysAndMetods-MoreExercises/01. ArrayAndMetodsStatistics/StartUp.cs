using System;
using System.Linq;

namespace _01.ArrayAndMetodsStatistics
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Min = " + GetMin(nums));
            Console.WriteLine("Max = " + GetMax(nums));
            Console.WriteLine("Sum = " + GetSum(nums));
            Console.WriteLine("Average = " + GetAvg(nums));
        }

        private static double GetMin(double[] nums)
        {
            double min = 0;
            min = nums[0];
            for (var i = 1; i < nums.Length; i++)
                if (nums[i] < min)
                    min = nums[i];
            return min;
        }

        private static double GetMax(double[] nums)
        {
            double max = 0;
            max = nums[0];
            for (var i = 1; i < nums.Length; i++)
                if (nums[i] > max)
                    max = nums[i];
            return max;
        }

        private static double GetSum(double[] nums)
        {
            double sum = 0;
            for (var i = 0; i < nums.Length; i++)
                sum += nums[i];
            return sum;
        }

        private static double GetAvg(double[] nums)
        {
            double sum = 0;
            double avg = 0;
            for (var i = 0; i < nums.Length; i++)
                sum += nums[i];
            avg = sum / nums.Length;
            return avg;
        }
    }
}