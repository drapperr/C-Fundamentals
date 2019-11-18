using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
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

                string model = carArgs[0];
                int fuelAmount = int.Parse(carArgs[1]);
                double fuelConsuptionPerKm = double.Parse(carArgs[2]);
                bool haveThisModel = false;

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        haveThisModel = true;
                    }
                }
                if (!haveThisModel)
                {
                    Car car = new Car(model, fuelAmount, fuelConsuptionPerKm);
                    cars.Add(car);
                }
            }
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] driveArgs = command.Split();

                string carModel = driveArgs[1];
                int amountOfKm = int.Parse(driveArgs[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        double neededFuel = amountOfKm * car.FuelConsuptionPerKm;
                        if (car.FuelAmount - neededFuel >= 0)
                        {
                            car.FuelAmount -= neededFuel;
                            car.TraveledDistance += amountOfKm;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient fuel for the drive");
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsuptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsuptionPerKm = fuelConsuptionPerKm;
            this.TraveledDistance = 0;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsuptionPerKm { get; set; }

        public int TraveledDistance { get; set; }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TraveledDistance}";
        }
    }
}
