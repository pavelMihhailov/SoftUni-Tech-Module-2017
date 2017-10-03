using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            string symbol = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(symbol);
                if (num >= 0 && num < 10)
                {
                    Console.WriteLine("digit");
                }
            }
            catch (Exception)
            {
                if (symbol == "a" || symbol == "e" || symbol == "o" || symbol == "i" || symbol == "u" || symbol == "y")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
