using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class StartUp
    {
        static double FahrenheitToCelsius(double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", FahrenheitToCelsius(n));
        }
    }
}
