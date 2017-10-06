using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                bool isSpecial = false;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11) isSpecial = true; Console.WriteLine($"{i} -> {isSpecial}");
                sum = 0;

            }
        }
    }
}
