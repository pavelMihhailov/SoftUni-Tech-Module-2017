using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = input.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine(String.Join(", ", result));

        }
    }
}
