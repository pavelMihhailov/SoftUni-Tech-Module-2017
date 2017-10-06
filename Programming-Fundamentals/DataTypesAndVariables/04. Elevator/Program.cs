using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)persons / capacityElevator);
            Console.WriteLine(courses);

        }
    }
}
