using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class StartUp
    {
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintBody(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("-");
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            PrintBody(n);
            PrintHeader(n);
        }
    }
}
