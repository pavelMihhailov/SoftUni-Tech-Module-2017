using System;

namespace _09.MultiplyEvenOdds
{
    class StartUp
    {
        static int SumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) sum += lastDigit;
                n /= 10;
            }
            return sum;
        }

        static int SumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0) sum += lastDigit;
                
                n /= 10;
            }
            return sum;
        }

        static int MultiplyOddAndEven(int n)
        {
            int result = 0;
            result = SumOfEvenDigits(n) * SumOfOddDigits(n);
            return result;
        }

        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultiplyOddAndEven(n);
            Console.WriteLine(result);
        }
    }
}
