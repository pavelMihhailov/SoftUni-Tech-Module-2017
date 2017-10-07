using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static bool IsPrime(long n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            for (long i = 2; i <= Math.Floor(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
