using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMetod
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(GetMax(a,b), c));
        }
    }
}
