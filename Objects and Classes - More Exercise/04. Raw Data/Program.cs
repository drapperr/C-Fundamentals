using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carArgs = Console.ReadLine().Split();
                //< Model > < EngineSpeed > < EnginePower > < CargoWeight > < CargoType >
                string model = carArgs[0];
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars = cars.Where(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000).ToList();
            }
            else if (command == "flamable")
            {
                cars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
