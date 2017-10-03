using System;

namespace _07.MathPower
{
    class StartUp
    {
        static double GetResult(double num, double index)
        {
            double pazq = num;
            for (int i = 2; i <= index; i++)
            {
                num *= pazq;
            }
            return num;
        }

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(n, p));
        }
    }
}
