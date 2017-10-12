using System;
using System.Linq;

namespace _07.InventoryMatcher
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var pricesOfProducts = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "done")
                    break;
                for (var i = 0; i < products.Length; i++)
                    if (products[i] == command)
                        Console.WriteLine(
                            $"{products[i]} costs: {pricesOfProducts[i]}; Available quantity: {quantities[i]}");
            }
        }
    }
}