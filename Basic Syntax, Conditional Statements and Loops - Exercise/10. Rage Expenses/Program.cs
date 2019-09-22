using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                bool trahsHeadset = false;
                bool trahsMouse = false;
                if (i % 2 == 0)
                {
                    headsetCount++;
                    trahsMouse = true;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                    trahsHeadset = true;
                }
                if (trahsMouse && trahsHeadset)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }
            double total = headsetPrice * headsetCount + mousePrice * mouseCount + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
