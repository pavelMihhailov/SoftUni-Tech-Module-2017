using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    total++;
                }
                catch (Exception)
                {
                    Console.WriteLine(total);
                    break;
                }
            }
        }
    }
}
