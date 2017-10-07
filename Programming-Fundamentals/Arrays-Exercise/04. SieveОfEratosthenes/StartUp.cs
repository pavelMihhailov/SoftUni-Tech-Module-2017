using System;

namespace _4.SieveОfEratosthenes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n + 1];
            bool[] isPrime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = false;
                    }
            }
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
