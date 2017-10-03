using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string varInHex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(varInHex, 16));
        }
    }
}
