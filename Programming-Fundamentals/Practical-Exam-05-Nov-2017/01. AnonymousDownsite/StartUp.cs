using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long countSites = long.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            decimal totalLoss = 0;

            for (long i = 0; i < countSites; i++)
            {
                string[] input = Console.ReadLine().Split();
                string siteName = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);

                totalLoss += siteVisits * pricePerVisit;
                list.Add(siteName);
            }

            BigInteger securityToken = 1;

            for (int i = 0; i < countSites; i++)
            {
                securityToken *= securityKey;
            }
            Console.WriteLine(string.Join("\n", list));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
