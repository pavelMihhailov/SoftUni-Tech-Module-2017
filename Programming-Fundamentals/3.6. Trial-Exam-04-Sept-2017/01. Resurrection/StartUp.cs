using System;

namespace _01.Resurrection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long phoenixCount = long.Parse(Console.ReadLine());

            for (decimal i = 0; i < phoenixCount; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lengthPerWing = long.Parse(Console.ReadLine());

                decimal totalYears = totalLength * totalLength * (totalWidth + 2 * lengthPerWing);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
