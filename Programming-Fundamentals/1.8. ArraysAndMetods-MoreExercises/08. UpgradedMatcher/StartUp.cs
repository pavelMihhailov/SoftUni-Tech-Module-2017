using System;
using System.Linq;

namespace _09.UpgradedMatcher
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var pricesOfProducts = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            long purchased = 0;

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "done")
                    break;
                var wantedQuantities = long.Parse(command[1]);
                for (var i = 0; i < products.Length; i++)
                    if (products[i] == command[0])
                    {
                        if (i > quantities.Length - 1)
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                        }
                        else if (wantedQuantities <= quantities[i])
                        {
                            Console.WriteLine(
                                $"{products[i]} x {wantedQuantities} costs {wantedQuantities * pricesOfProducts[i]:f2}");
                            quantities[i] -= wantedQuantities;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {products[i]}");
                        }
                        break;
                    }
            }
        }
    }
}