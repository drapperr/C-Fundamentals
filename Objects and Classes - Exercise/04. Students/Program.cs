using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student();

                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);

                students.Add(student);
            }
            students = students.OrderBy(x => x.Grade).Reverse().ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
    class Student
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public double Grade { set; get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
