using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int membersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < membersCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(name, age);
            }
            family.GetOldestMember();
        }
    }
    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(string name, int age)
        {
            People.Add(new Person(name, age));
        }
        public void GetOldestMember()
        {
            People = People.OrderByDescending(x => x.Age).ToList();
            Console.WriteLine($"{People[0].Name} {People[0].Age}");
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }


    }
}
