using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceHall = 0;
            double totalPrice = 0;

            if (groupSize <= 50)
            {
                priceHall = 2500;
                totalPrice += priceHall;
                if (package == "Normal")
                {
                    totalPrice += 500;
                    totalPrice -= (totalPrice * 5) / 100;
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice -= (totalPrice * 10) / 100;
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice -= (totalPrice * 15) / 100;
                }
            }
            else if (groupSize <= 100 && groupSize > 50)
            {
                priceHall = 5000;
                totalPrice += priceHall;
                if (package == "Normal")
                {
                    totalPrice += 500;
                    totalPrice -= (totalPrice * 5) / 100;
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice -= (totalPrice * 10) / 100;
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice -= (totalPrice * 15) / 100;
                }
            }
            else if (groupSize <= 120 && groupSize > 100)
            {
                priceHall = 7500;
                totalPrice += priceHall;
                if (package == "Normal")
                {
                    totalPrice += 500;
                    totalPrice -= (totalPrice * 5) / 100;
                }
                else if (package == "Gold")
                {
                    totalPrice += 750;
                    totalPrice -= (totalPrice * 10) / 100;
                }
                else if (package == "Platinum")
                {
                    totalPrice += 1000;
                    totalPrice -= (totalPrice * 15) / 100;
                }
            }
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            else if (priceHall == 2500)
            {
                double pricePerPerson = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (priceHall == 5000)
            {
                double pricePerPerson = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (priceHall == 7500)
            {
                double pricePerPerson = totalPrice / groupSize;
                Console.WriteLine($"We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

        }
    }
}
