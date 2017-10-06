using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _14.FactiorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int zeros = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
        
            while (factorial % 10 == 0)
            {
                zeros++;
                factorial /= 10;
            }
            Console.WriteLine(zeros);
        }
    }
}
