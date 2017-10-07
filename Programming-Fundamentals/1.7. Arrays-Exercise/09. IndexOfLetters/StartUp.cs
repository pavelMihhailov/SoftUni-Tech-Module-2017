using System;
using System.Linq;

namespace _09.IndexOfLetters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            char[] array2 = string.Join(string.Empty, array).ToCharArray();

            foreach (var bukva in array2)
            {
                Console.WriteLine($"{bukva} -> " + (int) (bukva - 97));
            }
        }
    }
}
