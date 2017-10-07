using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.TripleSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            long[] array = nums.Split(' ').Select(long.Parse).ToArray();
            bool found = false;

            for (long a = 0; a < array.Length; a++)
            {
                for (long b = a + 1; b < array.Length; b++)
                {
                    for (long c = 0; c < array.Length; c++)
                    {
                        if (array[a] + array[b] == array[c])
                        {
                            found = true;
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[c]}");
                            break;
                        }
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
