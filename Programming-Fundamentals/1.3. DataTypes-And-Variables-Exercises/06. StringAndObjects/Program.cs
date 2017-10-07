using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            string t2 = Console.ReadLine();
            object concatened = t1 + " " + t2;
            Console.WriteLine(concatened);
        }
    }
}
