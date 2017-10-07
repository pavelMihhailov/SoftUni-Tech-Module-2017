using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
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

        static double Point3(double p1, double j1)
        {
            double result = Math.Sqrt(Math.Pow(p1, 2) + Math.Pow(j1, 2));
            return result;
        }

        static double Point4(double p2, double j2)
        {
            double result = Math.Sqrt(Math.Pow(p2, 2) + Math.Pow(j2, 2));
            return result;
        }
        

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double j1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double j2 = double.Parse(Console.ReadLine());

            double firstPair = Point1(x1, y1) + Point2(x2, y2);
            double secondPair = Point3(p1, j1) + Point4(p2, j2);
            if (firstPair >= secondPair)
            {
                if (Point1(x1, y1) <= Point2(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (secondPair > firstPair)
            {
                if (Point3(p1, j1) <= Point4(p2, j2))
                {
                    Console.WriteLine($"({p1}, {j1})({p2}, {j2})");
                }
                else
                {
                    Console.WriteLine($"({p2}, {j2})({p1}, {j1})");
                }
            }
            

        }
     }
        
}
