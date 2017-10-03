using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double ddouble = 0;
            double masterSuite = 0;
            double studioDiscount = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                ddouble = 65;
                masterSuite = 75;
                if (nights > 7 && month == "October")
                {
                    studioDiscount = 47.5;
                }
                if (nights > 7 && (month == "May" || month == "October"))
                {
                    studio -= (studio * 5) / 100;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                ddouble = 72;
                masterSuite = 82;

                if (nights > 7 && month == "September")
                {
                    studioDiscount = 60;
                }
                else if (nights > 14 && month == "June")
                {
                    ddouble -= (ddouble * 10) / 100;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                ddouble = 77;
                masterSuite = 89;
                if (nights > 14)
                {
                    masterSuite -= (masterSuite * 15) / 100;
                }
            }
            Console.WriteLine($"Studio: {((studio * nights) - studioDiscount):f2} lv.");
            Console.WriteLine($"Double: {(ddouble * nights):f2} lv.");
            Console.WriteLine($"Suite: {(masterSuite * nights):f2} lv.");
        }
    }
}
