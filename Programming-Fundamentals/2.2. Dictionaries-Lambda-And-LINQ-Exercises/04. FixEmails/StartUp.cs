using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var info = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop") break;
                var email = Console.ReadLine();
                if (email.EndsWith("us") || email.EndsWith("uk")) continue;
                info.Add(name, email);
            }
            foreach (var person in info)
                Console.WriteLine($"{person.Key} -> {person.Value}");
        }
    }
}