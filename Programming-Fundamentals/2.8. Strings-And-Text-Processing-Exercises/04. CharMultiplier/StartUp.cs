using System;
using System.Linq;

namespace _04.CharMultiplier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string first = input[0];
            string second = input[1];
            int result = 0;

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }
            }
            else
            {
                var longerLength = Math.Max(first.Length, second.Length);
                var shorterLength = Math.Min(first.Length, second.Length);
                for (int i = 0; i < longerLength; i++)
                {
                    if (i > shorterLength - 1)
                    {
                        if (shorterLength == first.Length)
                        {
                            result += second[i];
                        }
                        else if (shorterLength == second.Length)
                        {
                            result += first[i];
                        }
                    }
                    else
                        result += first[i] * second[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
