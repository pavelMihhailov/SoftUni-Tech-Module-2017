using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static string GetName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            return name;
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
        }
    }
}
