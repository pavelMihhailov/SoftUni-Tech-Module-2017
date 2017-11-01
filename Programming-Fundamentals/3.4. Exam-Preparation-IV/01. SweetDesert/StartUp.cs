using System;

namespace _01.SweetDesert
{
    class StartUp
    {
        static void Main(string[] args)
        {
            decimal cashAvailable = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            decimal moneyNeeded = 0;
            int portions;
            if (guests % 6 != 0) portions = guests / 6 + 1;
            else portions = guests / 6;
            moneyNeeded += portions * (2 * priceBananas) + portions * (4 * priceEggs) +
                           portions * ((decimal) 0.2 * priceBerries);
            if (moneyNeeded <= cashAvailable)
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            else
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - cashAvailable:f2}lv more.");
        }
    }
}
