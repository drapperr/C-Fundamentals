using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = hours * 60 + minutes + 30;
            int hoursAfter30min = totalMinutes / 60;
            int minutesAfter30min = totalMinutes % 60;
            if (hoursAfter30min >= 24)
            {
                hoursAfter30min -= 24;
            }
            Console.WriteLine($"{hoursAfter30min}:{minutesAfter30min:D2}");
        }
    }
}
