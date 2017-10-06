using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());
            volume = (length * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
