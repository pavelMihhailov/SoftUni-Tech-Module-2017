using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hex = num.ToString("X");
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
