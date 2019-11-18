using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentPerson in peopleInput)
            {
                string[] personArgs = currentPerson.Split('=');
                string personName = personArgs[0];
                int personMoney = int.Parse(personArgs[1]);

                Person person = new Person(personName, personMoney);
                people.Add(person);
            }
            string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentProduct in productsInput)
            {
                string[] productArgs = currentProduct.Split('=');
                string productName = productArgs[0];
                int productCost = int.Parse(productArgs[1]);

                Product product = new Product(productName, productCost);
                products.Add(product);
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] splitedCommand = command.Split();
                string personName = splitedCommand[0];
                string productName = splitedCommand[1];

                int personIndex = -1;
                for (int i = 0; i < people.Count; i++)
                {
                    if (personName == people[i].Name)
                    {
                        personIndex = i;
                    }
                }
                people[personIndex].BuyProduct(personName, productName, products);
            }
            List<string> nothingBoughtNameList = new List<string>();

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].BagOfProducts.Count != 0)
                {
                    Console.WriteLine($"{people[i].Name} - {string.Join(", ", people[i].BagOfProducts)}");
                }
                else
                {
                    nothingBoughtNameList.Add(people[i].Name);
                }
            }
            foreach (var name in nothingBoughtNameList)
            {
                Console.WriteLine($"{name} - Nothing bought");
            }
        }
    }
    class Person
    {
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }
        public string Name { get; set; }
        public int Money { get; set; }
        public List<string> BagOfProducts { get; set; } = new List<string>();
        public void BuyProduct(string personName, string productName, List<Product> products)
        {
            int productIndex = -1;
            for (int i = 0; i < products.Count; i++)
            {
                if (productName == products[i].Name)
                {
                    productIndex = i;
                }
            }
            int productCost = products[productIndex].Cost;
            if (this.Money - productCost >= 0)
            {
                this.Money -= productCost;
                BagOfProducts.Add(productName);
                Console.WriteLine($"{personName} bought {productName}");
            }
            else
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
        }
    }
    class Product
    {
        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public int Cost { get; set; }

    }
}
