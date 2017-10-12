using System;
using System.Linq;

namespace _06.Heists
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var priceOfJewels = prices[0];
            var priceOfGold = prices[1];
            var expenses = 0;
            var jewels = 0;
            var gold = 0;
            var times = 0;
            while (true)
            {
                var heist = Console.ReadLine().Split(' ').ToArray();
                if (heist[0] == "Jail" && heist[1] == "Time")
                    break;
                times++;
                expenses += int.Parse(heist[1]);
                foreach (var symbol in heist[0])
                {
                    if (symbol == '%')
                        jewels++;
                    if (symbol == '$')
                        gold++;
                }
            }
            var totalEarnings = jewels * priceOfJewels + gold * priceOfGold;
            if (totalEarnings >= expenses)
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarnings - expenses);
            else
                Console.WriteLine("Have to find another job. Lost: {0}.", expenses - totalEarnings);
        }
    }
}