using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long isLong;
            if (long.TryParse(number, out isLong))
            {
                Console.WriteLine($"{number} can fit in:");
                sbyte isSByte;
                byte isByte;
                short isShort;
                ushort isUshort;
                int isInt;
                uint isUint;
                if (sbyte.TryParse(number, out isSByte))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(number, out isByte))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(number, out isShort))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(number, out isUshort))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(number, out isInt))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(number, out isUint))
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine(number + " can't fit in any type");
            }
        }
    }
}
