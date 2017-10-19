using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    internal class StartUp
    {
        private static void Main(string[] args)
        { 
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays =
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            var workDays = 0;

            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var currDate = i.DayOfWeek;
                var temp = new DateTime(1, i.Month, i.Day);

                if (!holidays.Contains(temp) && !currDate.Equals(DayOfWeek.Saturday) &&
                    !currDate.Equals(DayOfWeek.Sunday))
                    workDays++;
            }
            Console.WriteLine(workDays);
        }
    }
}