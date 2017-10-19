using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Circle
    {
        public double Center { get; set; }
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
    
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] input1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            ReadAndPrint(input, input1);
        }

        private static void ReadAndPrint(double[] input, double[] input1)
        {
            Circle firstCircle = new Circle();
            Circle secondCircle = new Circle();
            firstCircle.X = input[0];
            firstCircle.Y = input[1];
            firstCircle.Radius = input[2];
            secondCircle.X = input1[0];
            secondCircle.Y = input1[1];
            secondCircle.Radius = input1[2];

            if (Intersect(firstCircle, secondCircle)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            double xX = Math.Abs(c1.X - c2.X);
            double yY = Math.Abs(c1.Y - c2.Y);
            var distance = Math.Sqrt(Math.Pow(xX, 2) + Math.Pow(yY, 2));

            if (distance <= c1.Radius + c2.Radius) return true;
            else return false;
        }
    }
}
