using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    internal class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    internal class StartUp
    {
        private static void Main(string[] args)
        {
            var listOfStudents = new Dictionary<string, Student>();
            ReadDates(listOfStudents);
            ReadComments(listOfStudents);
            Print(listOfStudents);
        }

        private static void Print(Dictionary<string, Student> listOfStudents)
        {
            foreach (var student in listOfStudents.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                if (student.Value.Comments.Count > 0)
                    Console.WriteLine($"- {string.Join("\n- ", student.Value.Comments)}");
                Console.WriteLine("Dates attended:");
                if (student.Value.Dates.Count > 0)
                    foreach (var everyDate in student.Value.Dates.OrderBy(x => x.Date))
                        Console.WriteLine($"-- {everyDate.Day:d2}/{everyDate.Month:d2}/{everyDate.Year}");
            }
        }

        private static void ReadComments(Dictionary<string, Student> listOfStudents)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of comments") break;
                var input1 = input.Split('-').ToArray();
                var username = input1[0];
                var comments = input1[1];

                if (listOfStudents.ContainsKey(username))
                {
                    var comentars = new List<string>();
                    comentars.Add(comments);
                    listOfStudents[username].Comments.AddRange(comentars);
                }
            }
        }

        private static void ReadDates(Dictionary<string, Student> listOfStudents)
        {
            while (true)
            {
                var student = new Student();
                var input = Console.ReadLine();
                if (input == "end of dates") break;
                var input1 = input.Split(' ', ',').ToArray();
                var username = input1[0];
                student.Name = username;
                if (input1.Length >= 1)
                {
                    student.Dates = new List<DateTime>();
                    student.Comments = new List<string>();
                    for (var i = 1; i < input1.Length; i++)
                        student.Dates.Add(DateTime.ParseExact(input1[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                if (!listOfStudents.ContainsKey(username))
                    listOfStudents.Add(student.Name, student);
                else
                    listOfStudents[student.Name].Dates.AddRange(student.Dates);
            }
        }
    }
}