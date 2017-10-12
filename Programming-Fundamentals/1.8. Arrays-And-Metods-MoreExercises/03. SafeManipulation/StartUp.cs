using System;
using System.Linq;

namespace _03.SafeManipulation
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "END") break;
                if (command[0] == "Reverse")
                    input.Reverse();
                else if (command[0] == "Distinct")
                    input = input.Distinct().ToList();
                else if (command[0] == "Replace")
                    try
                    {
                        input[int.Parse(command[1])] = command[2];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                else
                    Console.WriteLine("Invalid input!");
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}