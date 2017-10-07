using System;
using System.Linq;

namespace _05.ReverseArrayOfStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            
            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
