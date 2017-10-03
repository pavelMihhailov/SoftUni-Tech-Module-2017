using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleArea
{
    class StartUp
    {
        static double GetArea(double a, double b)
        {
            return a * b / 2;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetArea(width, height);
            Console.WriteLine(area);
        }
    }
}
