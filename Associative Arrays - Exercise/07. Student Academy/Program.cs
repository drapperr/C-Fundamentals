using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> studentsAverageGrade = new Dictionary<string, double>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studenGrade = double.Parse(Console.ReadLine());

                if (!studentsAverageGrade.ContainsKey(studentName))
                {
                    studentsAverageGrade[studentName] = studenGrade;
                }
                else
                {
                    studentsAverageGrade[studentName] = (studentsAverageGrade[studentName] + studenGrade) / 2;
                }
            }
            studentsAverageGrade = studentsAverageGrade
                .Where(x => x.Value >= 4.5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in studentsAverageGrade)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}