using System;
using System.Linq;

namespace _07.SumOfArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxLength = Math.Max(arr1.Length, arr2.Length);
            int count = 0;
            for (int i = 0; i < maxLength; i++)
            {
                while (arr1.Length < arr2.Length)
                {
                    Array.Resize(ref arr1, arr1.Length + 1);
                    arr1[arr1.Length - 1] = arr1[i % arr1.Length];
                }
                while (arr2.Length < arr1.Length)
                {
                    if (count == 0)
                    {
                        Array.Resize(ref arr2, arr2.Length + 1);
                        arr2[arr2.Length - 1] = arr2[i % arr2.Length];
                        count++;
                    }
                    else if (count > 0)
                    {
                        Array.Resize(ref arr2, arr2.Length + 1);
                        arr2[arr2.Length - 1] = arr2[i + count % arr2.Length];
                        count++;
                    }
                }
                Console.Write(arr1[i] + arr2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
