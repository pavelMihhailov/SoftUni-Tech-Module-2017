using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    class StartUp
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "end") break;

                string command = input[0];
                switch (command)
                {
                    case "reverse":
                        Reverse(list, input);
                        break;
                    case "sort":
                        Sort(list, input);
                        break;
                    case "rollLeft":
                        RollLeft(list, input);
                        break;
                    case "rollRight":
                        RollRight(list, input);
                        break;
                }
            }
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        static List<string> Sort(List<string> list, string[] input)
        {
            int startIndex = int.Parse(input[2]);
            int count = int.Parse(input[4]);

            if (startIndex < 0 || startIndex > list.Count - 1 || count < 0 || count > list.Count || startIndex + count > list.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return list;
            }

            list.Sort(startIndex, count, null);
            return list;
        }

        static List<string> Reverse(List<string> list, string[] input)
        {
            int startIndex = int.Parse(input[2]);
            int count = int.Parse(input[4]);

            if (startIndex < 0 || startIndex > list.Count - 1 || count < 0 || count > list.Count || startIndex + count > list.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return list;
            }

            list.Reverse(startIndex, count);
            return list;
        }

        static List<string> RollLeft(List<string> list, string[] input)
        {
            int count = int.Parse(input[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return list;
            }

            for (int i = 0; i < count%list.Count; i++)
            {
                string temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
            return list;
        }

        static List<string> RollRight(List<string> list, string[] input)
        {
            int count = int.Parse(input[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return list;
            }

            for (int i = 0; i < count%list.Count; i++)
            {
                string temp = list.Last();
                list.RemoveAt(list.Count - 1);
                list.Insert(0, temp);
            }
            return list;
        }
    }
}