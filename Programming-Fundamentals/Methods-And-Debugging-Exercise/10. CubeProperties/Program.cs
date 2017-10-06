using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0;
            result = Result(side, parameter, result);
            Console.WriteLine("{0:f2}", result);
        }

        private static double Result(double side, string parameter, double result)
        {
            if (parameter == "face")
            {
                result += Math.Sqrt(2 * (side * side));
            }
            else if (parameter == "space")
            {
                result += Math.Sqrt(3 * (side * side));
            }
            else if (parameter == "volume")
            {
                result += side * side * side;
            }
            else if (parameter == "area")
            {
                result += 6 * (side * side);
            }

            return result;
        }
    }
}
