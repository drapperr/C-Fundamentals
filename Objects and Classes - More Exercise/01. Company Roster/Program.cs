using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int employeesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeesCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];

                Employee employee = new Employee(name, salary, department);

                employees.Add(employee);
            }
            List<Employee> coppyemployees = employees.ToList();

            double bestSumSalary = 0;
            string bestDepartment = string.Empty;

            while (coppyemployees.Count != 0)
            {
                double currentSumSalary = 0;
                string currentDepartment = coppyemployees[0].Department;
                for (int i = 0; i < coppyemployees.Count; i++)
                {
                    if (coppyemployees[i].Department == currentDepartment)
                    {
                        currentSumSalary += coppyemployees[i].Salary;
                        coppyemployees.RemoveAt(i);
                        i--;
                    }
                }
                if (currentSumSalary > bestSumSalary)
                {
                    bestSumSalary = currentSumSalary;
                    bestDepartment = currentDepartment;
                }
            }
            employees = employees.Where(x => x.Department == bestDepartment).OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }

        public double Salary { get; set; }
        public string Department { get; set; }

    }
}
