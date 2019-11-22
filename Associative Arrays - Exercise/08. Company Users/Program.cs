using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyEmployees = new SortedDictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input.Split(" -> ");

                string companyName = splitedInput[0];
                string employeeId = splitedInput[1];

                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees[companyName] = new List<string>();
                }
                if (!companyEmployees[companyName].Contains(employeeId))
                {
                    companyEmployees[companyName].Add(employeeId);
                }
            }
            foreach (var company in companyEmployees)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}