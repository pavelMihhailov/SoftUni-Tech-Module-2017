using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometricCalculator
{
    class Program
    {
        static double AreaCalc(string typeFigure)
        {
            double result;
            
            if (typeFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2;
            }
            else if (typeFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side * side;
            }
            else if (typeFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = width * height;
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * radius * radius;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            Console.WriteLine($"{AreaCalc(type):f2}");
        }
    }
}
