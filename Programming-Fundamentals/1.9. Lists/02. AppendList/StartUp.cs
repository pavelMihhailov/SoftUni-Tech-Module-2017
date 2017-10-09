using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split('|');

            List<int> result = new List<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int[] elements = array[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                result.AddRange(elements);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}