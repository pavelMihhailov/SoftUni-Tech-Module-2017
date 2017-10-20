using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPeople = new List<Person>();
            while (true)
            {
                Person person = new Person();
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End") break;
                person.Name = input[0];
                person.ID = input[1];
                person.Age = int.Parse(input[2]);
                listOfPeople.Add(person);
            }
            foreach (var person in listOfPeople.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
