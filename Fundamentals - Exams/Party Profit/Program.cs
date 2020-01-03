using System;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 0;

            for (int day = 1; day <= days; day++)
            {
                if (day % 10 == 0)
                {
                    partySize -= 2;
                }
                if (day % 15 == 0)
                {
                    partySize += 5;
                }
                coins += 50;
                coins -= 2 * partySize;
                if (day % 3 == 0)
                {
                    coins -= 3 * partySize;
                }
                if (day % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (day % 3 == 0)
                    {
                        coins -= 2 * partySize;
                    }
                }
            }
            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}