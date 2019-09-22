using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            int lightsabersCount = (int)Math.Ceiling(studentsCount * 1.1);
            int beltsCount = studentsCount;
            if (beltsCount >= 6)
            {
                beltsCount -= studentsCount / 6;
            }
            int robesCount = studentsCount;
            double total = lightsabersPrice * lightsabersCount + robesPrice * robesCount + beltsPrice * beltsCount;
            if (total <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - moneyAmount:f2}lv more.");
            }
        }
    }
}
