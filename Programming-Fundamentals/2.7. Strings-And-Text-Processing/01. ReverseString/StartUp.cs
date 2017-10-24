using System;

namespace _01.ReverseString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = null;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
