using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    internal class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }

    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var shop = new Dictionary<string, double>();

            var amountEntities = int.Parse(Console.ReadLine());
            ReadShopSupply(shop, amountEntities);

            var listOfCustomers = new List<Customer>();
            var totalBill = ReadCustomersDesires(shop, listOfCustomers);

            PrintResult(listOfCustomers, totalBill);
        }

        private static void ReadShopSupply(Dictionary<string, double> shop, int amountEntities)
        {
            for (var i = 0; i < amountEntities; i++)
            {
                var input = Console.ReadLine().Split('-');
                var product = input[0];
                var priceProduct = double.Parse(input[1]);
                if (!shop.ContainsKey(product))
                    shop.Add(product, 0);
                shop[product] = priceProduct;
            }
        }

        private static double ReadCustomersDesires(Dictionary<string, double> shop, List<Customer> listOfCustomers)
        {
            double totalBill = 0;

            while (true)
            {
                var newCustomer = new Customer();
                var input = Console.ReadLine();
                if (input == "end of clients") break;
                var input1 = input.Split(',', '-').ToArray();
                var name = input1[0];
                var wantedProduct = input1[1];
                var wantedQuantity = double.Parse(input1[2]);

                if (!shop.ContainsKey(wantedProduct)) continue;

                newCustomer.Name = name;
                newCustomer.ShopList = new Dictionary<string, double>();
                newCustomer.ShopList.Add(wantedProduct, wantedQuantity);

                if (listOfCustomers.Any(c => c.Name == name))
                {
                    var existingCustomer = listOfCustomers.First(c => c.Name == name);
                    if (existingCustomer.ShopList.ContainsKey(wantedProduct))
                        existingCustomer.ShopList[wantedProduct] += wantedQuantity;
                    else
                        existingCustomer.ShopList[wantedProduct] = wantedQuantity;
                }
                else
                {
                    listOfCustomers.Add(newCustomer);
                }
                totalBill += wantedQuantity * shop[wantedProduct];
            }
            foreach (var customer in listOfCustomers)
            foreach (var item in customer.ShopList)
            foreach (var product in shop)
                if (item.Key == product.Key)
                    customer.Bill += product.Value * item.Value;
            return totalBill;
        }

        private static void PrintResult(List<Customer> listOfCustomers, double totalBill)
        {
            var result = listOfCustomers.OrderBy(x => x.Name);
            foreach (var customer in result)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var item in customer.ShopList)
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}