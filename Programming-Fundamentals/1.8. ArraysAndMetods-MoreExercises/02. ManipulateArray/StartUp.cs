using System;
using System.Linq;

namespace _02.ManipulateArray
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "Reverse")
                    input.Reverse();
                else if (command[0] == "Distinct")
                    input = input.Distinct().ToList();
                else if (command[0] == "Replace")
                    input[int.Parse(command[1])] = command[2];
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}