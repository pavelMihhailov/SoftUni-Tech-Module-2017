using System;

namespace _01.SoftUniCoffeeOrders
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                totalPrice += TakeOrders();
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        static decimal TakeOrders()
        {
            decimal price = 0;

            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string date = Console.ReadLine();
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            DateTime parseDate = DateTime.ParseExact(date, "d/M/yyyy", null);
            int daysInMonth = DateTime.DaysInMonth(parseDate.Year, parseDate.Month);

            price = (daysInMonth * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:f2}");
            return price;
        }
    }
}
