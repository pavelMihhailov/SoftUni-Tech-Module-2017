using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
