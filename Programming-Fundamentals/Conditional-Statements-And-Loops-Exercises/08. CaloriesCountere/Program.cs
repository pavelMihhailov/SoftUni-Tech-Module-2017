using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCountere
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int totalCal = 0;

            for (int i = 0; i < times; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    totalCal += 500;
                }
                if (ingredients == "tomato sauce")
                {
                    totalCal += 150;
                }
                if (ingredients == "salami")
                {
                    totalCal += 600;
                }
                if (ingredients == "pepper")
                {
                    totalCal += 50;
                }
            }
            Console.WriteLine("Total calories: " + totalCal);
        }
    }
}
