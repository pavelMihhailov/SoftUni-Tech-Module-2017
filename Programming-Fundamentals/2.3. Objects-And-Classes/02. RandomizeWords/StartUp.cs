using System;
using System.Linq;

namespace _02.Randomizeinput
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            
            Random rnd = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int newPosition = rnd.Next(input.Count);
                string oldPosition = input[i];
                input[i] = input[newPosition];
                input[newPosition] = oldPosition;
            }
            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}
