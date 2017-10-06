using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static List<long> CheckPrime(long startNum, long endNum)
        {
            var result = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                if (i == 0 || i == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (long j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        
                    }
                }
                if (isPrime)
                    {
                        result.Add(i);
                    }
                
            }
            return result;
        }

        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", CheckPrime(start, end)));
        }
    }
}
