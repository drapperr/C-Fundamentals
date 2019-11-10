using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input.Split();

                Person person = new Person();

                person.Name = splitedInput[0];
                person.Id = splitedInput[1];
                person.Age = int.Parse(splitedInput[2]);

                people.Add(person);
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var person in people)
            {
                string name = person.Name;
                string id = person.Id;
                int age = person.Age;
                Console.WriteLine($"{name} with ID: {id} is {age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { set; get; }
        public string Id { set; get; }
        public int Age { set; get; }
    }
}
