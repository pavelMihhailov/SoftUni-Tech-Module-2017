using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameLastDigit
{
    class Program
    {
        static long GetLastDigit(long n)
        {
            long digit = Math.Abs(n % 10);
            return digit;
        }

        static void Print(long n)
        {
            if (GetLastDigit(n) == 0)
                Console.WriteLine("zero");
            else if (GetLastDigit(n) == 1)
                Console.WriteLine("one");
            else if (GetLastDigit(n) == 2)
                Console.WriteLine("two");
            else if (GetLastDigit(n) == 3)
                Console.WriteLine("three");
            else if (GetLastDigit(n) == 4)
                Console.WriteLine("four");
            else if (GetLastDigit(n) == 5)
                Console.WriteLine("five");
            else if (GetLastDigit(n) == 6)
                Console.WriteLine("six");
            else if (GetLastDigit(n) == 7)
                Console.WriteLine("seven");
            else if (GetLastDigit(n) == 8)
                Console.WriteLine("eight");
            else if (GetLastDigit(n) == 9)
                Console.WriteLine("nine");
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Print(n);
        }
    }
}
