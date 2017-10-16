using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] p2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine("{0:f3}", CalcDistance(p1, p2));
        }

        public static double CalcDistance(double[] p1, double[] p2)
        {
            double x1 = p1[0];
            double y1 = p1[1];
            double x2 = p2[0];
            double y2 = p2[1];

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
    }
}
