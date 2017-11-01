using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    class StartUp
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "end") break;

                switch (input[0])
                {
                    case "exchange":
                        Exchange(input, list);
                        break;
                    case "max":
                        Max(input, list);
                        break;
                    case "min":
                        Min(input, list);
                        break;
                    case "first":
                        First(input, list);
                        break;
                    case "last":
                        Last(input, list);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        static List<int> Exchange(string[] input, List<int> list)
        {
            List<int> first = new List<int>();
            List<int> second = new List<int>();

            int index = int.Parse(input[1]);

            if (index < 0 || index > list.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return list;
            }

            for (int i = 0; i <= index; i++)
            {
                first.Add(list[0]);
                list.RemoveAt(0);
            }
            second.AddRange(list);
            list.Clear();
            list.AddRange(second);
            list.AddRange(first);
            return list;
        }

        static void Max(string[] input, List<int> list)
        {
            int max = Int32.MinValue;

            if (input[1] == "even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && list[i] >= max)
                    {
                        max = list[i];
                    }
                }
            }
            else if (input[1] == "odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0 && list[i] >= max)
                    {
                        max = list[i];
                    }
                }
            }
            if (max > Int32.MinValue) Console.WriteLine(list.LastIndexOf(max));
            else Console.WriteLine("No matches");
        }

        static void Min(string[] input, List<int> list)
        {
            int min = Int32.MaxValue;

            if (input[1] == "even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && list[i] <= min)
                    {
                        min = list[i];
                    }
                }
            }
            else if (input[1] == "odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0 && list[i] <= min)
                    {
                        min = list[i];
                    }
                }
            }
            if (min < Int32.MaxValue) Console.WriteLine(list.LastIndexOf(min));
            else Console.WriteLine("No matches");
        }

        static void First(string[] input, List<int> list)
        {
            List<int> listOfInts = new List<int>();

            int count = int.Parse(input[1]);
            string evenOdd = input[2];

            if (count > list.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            
            if (evenOdd == "even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        listOfInts.Add(list[i]);
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        listOfInts.Add(list[i]);
                    }
                }
            }
            if (count > listOfInts.Count - 1)
            {
                Console.WriteLine("[" + string.Join(", ", listOfInts) + "]");
            }
            else
            {
                List<int> result = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    result.Add(listOfInts[i]);
                }
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        static void Last(string[] input, List<int> list)
        {
            List<int> listOfInts = new List<int>();

            int count = int.Parse(input[1]);
            string evenOdd = input[2];

            if (count > list.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (evenOdd == "even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        listOfInts.Add(list[i]);
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        listOfInts.Add(list[i]);
                    }
                }
            }
            if (count > listOfInts.Count - 1)
            {
                Console.WriteLine("[" + string.Join(", ", listOfInts) + "]");
            }
            else
            {
                List<int> result = new List<int>();
                for (int i = listOfInts.Count - 1; i >= listOfInts.Count - count; i--)
                {
                    result.Insert(0, listOfInts[i]);
                }
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}
