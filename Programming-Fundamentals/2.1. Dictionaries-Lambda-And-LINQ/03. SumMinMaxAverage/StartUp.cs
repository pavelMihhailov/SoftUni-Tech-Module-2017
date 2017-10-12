using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumMinMaxAverage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            Console.WriteLine("Sum = {0}", list.Sum());
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
            Console.WriteLine("Average = {0}", list.Average());
        }
    }
}
