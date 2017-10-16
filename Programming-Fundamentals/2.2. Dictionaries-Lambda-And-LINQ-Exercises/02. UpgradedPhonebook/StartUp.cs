using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.UpgradedPhonebook
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "END") break;
                if (command[0] == "A")
                {
                    var name = command[1];
                    var number = command[2];
                    if (phonebook.ContainsKey(name))
                        phonebook[name] = number;
                    else
                        phonebook.Add(name, number);
                }
                else if (command[0] == "S")
                {
                    var name = command[1];
                    if (phonebook.ContainsKey(name))
                        foreach (var person in phonebook)
                        {
                            if (person.Key.Equals(name))
                                Console.WriteLine($"{person.Key} -> {person.Value}");
                        }
                    else Console.WriteLine($"Contact {name} does not exist.");
                }
                if (command[0] == "ListAll")
                    foreach (var person in phonebook)
                        Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}