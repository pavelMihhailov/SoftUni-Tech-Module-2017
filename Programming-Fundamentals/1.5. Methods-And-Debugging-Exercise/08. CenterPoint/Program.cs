using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static double Point1(double x1, double y1)
        {
            double result = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return result;
        }

        static double Point2(double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            return result;
        }
        
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (Point1(x1, y1) < Point2(x2, y2))
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else if (Point1(x1, y1) > Point2(x2, y2))
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
    }
}
