using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string correctPassword = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                correctPassword += userName[i];
            }
            int counter = 0;
            while (counter < 3)
            {
                string password = Console.ReadLine();
                if (password == correctPassword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
            Console.WriteLine($"User {userName} blocked!");
        }
    }
}
