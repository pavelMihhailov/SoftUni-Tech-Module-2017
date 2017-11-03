using System;

namespace _01.PokeMon
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targetsDown = 0;
            int oldN = n;

            while (true)
            {
                if (n >= m)
                {
                    n -= m;
                    targetsDown++;
                }
                else break;
                if (n * 2 == oldN)
                {
                    if (y <= 0) continue;
                    else n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetsDown);
        }
    }
}