using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var ingredients = Console.ReadLine().Split(' ').ToArray();
            var lengthIngr = int.Parse(Console.ReadLine());
            var total = 0;

            for (var i = 0; i < ingredients.Length; i++)
            {
                if (lengthIngr == ingredients[i].Length)
                {
                    Console.WriteLine("Adding {0}.", ingredients[i]);
                    total++;
                }
                if (total == 10)
                    break;
            }
            Console.WriteLine("Made pizza with total of {0} ingredients.", total);
            Console.Write("The ingredients are: ");
            var total2 = 0;
            for (var i = 0; i < ingredients.Length; i++)
                if (total2 < total - 1)
                {
                    if (lengthIngr == ingredients[i].Length)
                    {
                        Console.Write("{0}, ", ingredients[i]);
                        total2++;
                    }
                }
                else
                {
                    if (lengthIngr == ingredients[i].Length)
                    {
                        Console.WriteLine("{0}.", ingredients[i]);
                        break;
                    }
                }
        }
    }
}