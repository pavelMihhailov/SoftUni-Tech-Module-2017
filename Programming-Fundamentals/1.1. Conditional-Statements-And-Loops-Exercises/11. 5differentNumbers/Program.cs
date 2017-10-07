using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5differentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int n1 = num1; n1 <= num2; n1++)
            {
                for (int n2 = num1; n2 <= num2; n2++)
                {
                    for (int n3 = num1; n3 <= num2; n3++)
                    {
                        for (int n4 = num1; n4 <= num2; n4++)
                        {
                            for (int n5 = num1; n5 <= num2; n5++)
                            {
                                if (num1 <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= num2)
                                {
                                    Console.Write($"{n1} {n2} {n3} {n4} {n5}");
                                    Console.WriteLine();
                                }
                                else if ((num2 - num1) < 5)
                                {
                                    Console.WriteLine("No");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
