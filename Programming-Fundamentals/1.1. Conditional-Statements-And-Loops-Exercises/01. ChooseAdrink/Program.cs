using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseAdrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();

            switch (proffession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswomen":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
