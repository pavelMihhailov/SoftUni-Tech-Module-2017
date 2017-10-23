using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MostFrequentNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = new Dictionary<int, int>();
            var numbers = File.ReadAllText("input.txt")
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var number in numbers)
            {
                if (input.ContainsKey(number))
                    input[number]++;
                else
                    input[number] = 1;
            }
            File.WriteAllText("output.txt", input
                .Aggregate((a, b) => a.Value >= b.Value ? a : b)
                .Key.ToString());
        }
    }
}
