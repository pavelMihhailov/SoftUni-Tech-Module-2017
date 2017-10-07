using System;

namespace _03.LastKNumsSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            for (long i = 1; i < array.Length; i++)
            {
                for (long j = 0; j <= k; j++)
                {
                    if (i - j >= 0)
                    {
                        array[i] += array[i - j];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
