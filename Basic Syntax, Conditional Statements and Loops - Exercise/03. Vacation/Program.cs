using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double total = 0;
            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
            }
            total = people * price;
            if (groupType == "Students" && people >= 30)
            {
                total -= total * 0.15;
            }
            if (groupType == "Business" && people >= 100)
            {
                total -= 10 * price;
            }
            if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                total -= total * 0.05;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}