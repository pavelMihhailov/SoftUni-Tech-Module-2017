using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "END") break;
                var name = command[1];
                if (command[0] == "A")
                {
                    var number = command[2];
                    if (phonebook.ContainsKey(name))
                        phonebook[name] = number;
                    else
                        phonebook.Add(name, number);
                }
                else if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                        foreach (var person in phonebook)
                            if (person.Key.Equals(name))
                                Console.WriteLine($"{person.Key} -> {person.Value}");
                    else Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}