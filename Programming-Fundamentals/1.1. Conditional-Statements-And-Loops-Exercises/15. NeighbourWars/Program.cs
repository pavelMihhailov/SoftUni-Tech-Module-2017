using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int rounds = 0;

            while (true)
            {
                for (int i = 1; i <= 100000; i++)
                {

                    if (i % 2 != 0)
                    {
                        goshoHealth -= peshoDamage;
                        if (goshoHealth > 0)
                        {
                            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");

                        }
                        rounds++;
                    }
                    else if (i % 2 == 0)
                    {
                        peshoHealth -= goshoDamage;
                        if (peshoHealth > 0)
                        {
                            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");

                        }
                        rounds++;
                    }
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {rounds}th round.");
                        return;
                    }
                    else if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {rounds}th round.");
                        return;
                    }
                    if (i % 3 == 0)
                    {
                        peshoHealth += 10;
                        goshoHealth += 10;
                    }
                }
            }
        }
    }
}
