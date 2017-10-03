using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int allIngred = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                allIngred++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {allIngred} ingredients.");
        }
    }
}
