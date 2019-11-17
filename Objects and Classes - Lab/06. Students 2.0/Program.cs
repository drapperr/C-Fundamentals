using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedInput = input.Split();

                Student student = new Student();

                student.FirstName = splitedInput[0];
                student.LastName = splitedInput[1];
                student.Age = splitedInput[2];
                student.HomeTown = splitedInput[3];

                RemoveIfSutdentIsExisting(studentsList, student);

                studentsList.Add(student);
            }
            string cityName = Console.ReadLine();

            foreach (var student in studentsList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static void RemoveIfSutdentIsExisting(List<Student> studentsList, Student student)
        {
            foreach (var studentInList in studentsList)
            {
                if (student.FirstName == studentInList.FirstName
                    && student.LastName == studentInList.LastName)
                {
                    studentsList.Remove(studentInList);
                    break;
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
}
