using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvgGrades
        {
            get
            {
                return Grades.Average();
            }
        }
    }
    
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ReadAndPrintStudentInfo(n);
        }

        private static void ReadAndPrintStudentInfo(int n)
        {
            List<Student> listOfStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                Student student = new Student();
                student.Name = input[0];
                input.RemoveAt(0);
                student.Grades = input.Select(double.Parse).ToList();
                listOfStudents.Add(student);
            }

            listOfStudents = listOfStudents.Where(x => x.AvgGrades >= 5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AvgGrades).ToList();

            for (int i = 0; i < listOfStudents.Count; i++)
            {
                Console.WriteLine($"{listOfStudents[i].Name} -> {listOfStudents[i].AvgGrades:f2}");
            }
        }
    }
}
