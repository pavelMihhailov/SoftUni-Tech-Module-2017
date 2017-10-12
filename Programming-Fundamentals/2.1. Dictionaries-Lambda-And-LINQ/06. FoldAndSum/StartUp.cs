using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> row1 = list.Take(list.Count / 4).Reverse().ToList();
            row1.AddRange(list.Skip(3*(list.Count / 4)).Take(list.Count / 4).Reverse());
            List<int> row2 = list.Skip(list.Count / 4).Take(2 * (list.Count / 4)).ToList();

            var sum = row1.Select((x, jdkd) => x + row2[jdkd]).ToList();
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
