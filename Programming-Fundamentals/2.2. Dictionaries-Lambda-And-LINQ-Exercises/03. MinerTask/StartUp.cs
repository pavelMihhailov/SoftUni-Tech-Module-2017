using System;
using System.Collections.Generic;

namespace _03.MinerTask
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop") break;
                var quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(resource))
                    resources[resource] += quantity;
                else
                    resources.Add(resource, quantity);
            }
            foreach (var item in resources)
                Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}