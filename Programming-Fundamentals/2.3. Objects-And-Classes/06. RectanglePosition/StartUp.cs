using System;
using System.Linq;

namespace _06.RectanglePosition
{
    internal class StartUp
    {
        private static bool IsInside(Rectangle rec1, Rectangle rec2)
        {
            if (rec1.left >= rec2.left && rec1.right <= rec2.right && rec1.top <= rec2.top &&
                rec1.bottom <= rec2.bottom)
                return true;
            return false;
        }

        private static Rectangle ReadRectangles()
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var r = new Rectangle();
            r.left = arr[0];
            r.top = arr[1];
            r.width = arr[2];
            r.height = arr[3];
            r.right = r.left + r.width;
            r.bottom = r.top + r.height;
            return r;
        }

        private static void Main(string[] args)
        {
            var r1 = ReadRectangles();
            var r2 = ReadRectangles();
            if (IsInside(r1, r2))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not inside");
        }

        private class Rectangle
        {
            public double left { get; set; }
            public double top { get; set; }
            public double width { get; set; }
            public double height { get; set; }
            public double right { get; set; }
            public double bottom { get; set; }
        }
    }
}