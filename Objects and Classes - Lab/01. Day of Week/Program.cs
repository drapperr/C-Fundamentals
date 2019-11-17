using System;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split("-")
                .Select(int.Parse)
                .ToArray();
            int day = input[0];
            int month = input[1];
            int year = input[2];
            DateTime currentDate = new DateTime(year, month, day);
            Console.WriteLine(currentDate.DayOfWeek);
        }
    }
}
