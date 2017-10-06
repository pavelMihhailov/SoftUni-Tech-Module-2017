using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                bool isSpecialNum = false;
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecialNum = true;
                }
                sum = 0;
                    Console.WriteLine($"{i} -> {isSpecialNum}");
                
            }

        }
    }
}
