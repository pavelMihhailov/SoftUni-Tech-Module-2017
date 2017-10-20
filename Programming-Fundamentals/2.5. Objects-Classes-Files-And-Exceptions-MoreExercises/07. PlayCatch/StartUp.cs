using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PlayCatch
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int exceptions = 0;
            while (true)
            {
                if (exceptions == 3)
                {
                    Console.WriteLine(string.Join(", ", input));
                    break;
                }
                try
                {
                    string[] command = Console.ReadLine().Split();
                    ReplaceCommand(input, command);
                    PrintCommant(input, command);
                    ShowCommand(input, command);
                }
                catch (ArgumentOutOfRangeException)
                {
                    exceptions++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (FormatException)
                {
                    exceptions++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }
        }

        private static void ShowCommand(List<int> input, string[] command)
        {
            if (command[0] == "Show")
            {
                Console.WriteLine(input.ElementAt(int.Parse(command[1])));
            }
        }

        private static void PrintCommant(List<int> input, string[] command)
        {
            if (command[0] == "Print")
            {
                var startIndex = int.Parse(command[1]);
                var endIndex = int.Parse(command[2]);
                List<int> list = new List<int>();
                for (int i = startIndex; i <= endIndex; i++)
                {
                    list.Add(input[i]);
                }
                Console.WriteLine(string.Join(", ", list));
            }
        }

        private static void ReplaceCommand(List<int> input, string[] command)
        {
            if (command[0] == "Replace")
            {
                var atIndex = int.Parse(command[1]);
                var element = int.Parse(command[2]);
                input.RemoveAt(atIndex);
                input.Insert(atIndex, element);
            }
        }
    }
}
