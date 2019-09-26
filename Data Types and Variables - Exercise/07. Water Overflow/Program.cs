using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capaciyty = 255;
            int currentLiters = 0;
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                int inputLiters = int.Parse(Console.ReadLine());
                if (currentLiters + inputLiters <= capaciyty)
                {
                    currentLiters += inputLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentLiters);
        }
    }
}
