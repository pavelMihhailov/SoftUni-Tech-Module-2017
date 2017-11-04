using System;
using System.Linq;

namespace _02.Icarus
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int initialIndex = int.Parse(Console.ReadLine());
            int power = 1;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Supernova") break;

                string direction = input[0];
                int steps = int.Parse(input[1]);

                if (direction == "left")
                {
                    TakeDamage(arr, ref initialIndex, ref power, steps);
                }
                else if (direction == "right")
                {
                    TakeDamagee(arr, ref initialIndex, ref power, steps);
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        private static void TakeDamagee(int[] arr, ref int initialIndex, ref int power, int steps)
        {
            for (int i = 1; i <= steps; i++)
            {
                initialIndex++;

                if (initialIndex > arr.Length - 1)
                {
                    initialIndex = 0;
                    power++;
                }
                arr[initialIndex] -= power;
            }
        }

        private static void TakeDamage(int[] arr, ref int initialIndex, ref int power, int steps)
        {
            for (int i = 1; i <= steps; i++)
            {
                initialIndex--;

                if (initialIndex < 0)
                {
                    initialIndex = arr.Length - 1;
                    power++;
                }
                arr[initialIndex] -= power;
            }
        }
    }
}
