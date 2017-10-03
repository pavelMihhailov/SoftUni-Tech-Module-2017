using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int combinations = 0;

            for (int n1 = N; n1 >= 1; n1--)
            {
                for (int n2 = 1; n2 <= M; n2++)
                {
                    totalSum += 3 * (n1 * n2);
                    combinations++;
                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                }
                if (totalSum >= maxSum)
                {
                    break;
                }
            }
            Console.WriteLine($"{combinations} combinations");
            if (totalSum >= maxSum)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine("Sum: " + totalSum);
            }
        }
    }
}
