using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new char[] {':', ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = input[0];
            
            while (input[0] != "JOKER")
            {
                if (!people.ContainsKey(name))
                {
                    people.Add(name, new List<string>());
                }
                
                for (int i = 1; i < input.Length; i++)
                {
                    if (people[name].Contains(input[i]))
                    {
                        continue;
                    }
                    else
                    {
                        people[name].Add(input[i]);
                    }
                }
                input = Console.ReadLine().Split(':').ToArray();
            }

        }
    }
}
