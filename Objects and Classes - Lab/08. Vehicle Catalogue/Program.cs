using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            Catalog catalog = ReadInput();

            PrintCatalog(catalog);
        }

        private static void PrintCatalog(Catalog catalog)
        {
            if (catalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach (var car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            if (catalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach (var truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

        private static Catalog ReadInput()
        {
            Catalog catalog = new Catalog();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedInput = input.Split("/");

                string type = splitedInput[0];
                string brand = splitedInput[1];
                string model = splitedInput[2];
                int powerOrWeight = int.Parse(splitedInput[3]);


                if (type == "Truck")
                {
                    Truck newTruck = new Truck();

                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = powerOrWeight;


                    catalog.Trucks.Add(newTruck);
                }
                else if (type == "Car")
                {
                    Car newCar = new Car();

                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = powerOrWeight;

                    catalog.Cars.Add(newCar);

                }
            }
            catalog.Cars = catalog.Cars.OrderBy(x => x.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(x => x.Brand).ToList();

            return catalog;
        }


    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
