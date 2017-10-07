using System;

namespace _02.RevertArraysOfInt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr1[i] = number;
            }

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                arr2[j] = arr1[i];
                j++;
            }
            Console.Write(string.Join(" ", arr2));
            Console.WriteLine();
        }
    }
}
