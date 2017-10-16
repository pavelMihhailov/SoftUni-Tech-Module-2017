using System;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var points = ReadAllPoints();
            var closestTwoPoints = FindClosest2Points(points);

            Console.WriteLine("{0:f3}", CalculateDiff(closestTwoPoints[0], closestTwoPoints[1]));
            Print(closestTwoPoints[0]);
            Print(closestTwoPoints[1]);
        }

        private static Point ReadOnePoint()
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var onePoint = new Point {X = arr[0], Y = arr[1]};
            return onePoint;
        }

        private static Point[] ReadAllPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (var i = 0; i < n; i++)
                points[i] = ReadOnePoint();
            return points;
        }

        private static double CalculateDiff(Point x, Point y)
        {
            var sideA = x.X - y.X;
            var sideB = x.Y - y.Y;
            var distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }

        private static Point[] FindClosest2Points(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (var i = 0; i < points.Length; i++)
            for (var j = i + 1; j < points.Length; j++)
            {
                var distance = CalculateDiff(points[i], points[j]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTwoPoints = new[] {points[i], points[j]};
                }
            }
            return closestTwoPoints;
        }

        private static void Print(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        private class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}