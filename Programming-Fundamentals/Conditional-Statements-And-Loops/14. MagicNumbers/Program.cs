using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = Char.Parse(Console.ReadLine());
            char secondLetter = Char.Parse(Console.ReadLine());
            char notPrintLetter = Char.Parse(Console.ReadLine());

            for (char letter1 = firstLetter; letter1 <= secondLetter; letter1++)
            {
                for (char letter2 = firstLetter; letter2 <= secondLetter; letter2++)
                {
                    for (char letter3 = firstLetter; letter3 <= secondLetter; letter3++)
                    {
                        if (letter1 != notPrintLetter && letter2 != notPrintLetter && letter3 != notPrintLetter)
                        {
                            Console.Write($"{letter1}{letter2}{letter3} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
