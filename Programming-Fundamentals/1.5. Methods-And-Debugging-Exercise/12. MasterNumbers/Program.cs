using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class Program
    {
        static bool IsPalindrome(int num)
        {
            string nummm = num.ToString();
            bool isPalindrom = true;
            for (int i = 0; i < nummm.Length / 2; i++)
            {
                if (nummm[i] != nummm[nummm.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool EvenDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && EvenDigit(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
