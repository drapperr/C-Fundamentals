using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutFall 4   $39.99
            //CS: OG  $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99
            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpent = currentBalance;
            string game = string.Empty;
            while ((game = Console.ReadLine()) != "Game Time")
            {
                if (game == "OutFall 4" || game == "RoverWatch Origins Edition")
                {
                    if (currentBalance - 39.99 >= 0)
                    {
                        currentBalance -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (game == "CS: OG")
                {
                    if (currentBalance - 15.99 >= 0)
                    {
                        currentBalance -= 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (currentBalance - 19.99 >= 0)
                    {
                        currentBalance -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (currentBalance - 59.99 >= 0)
                    {
                        currentBalance -= 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (currentBalance - 29.99 >= 0)
                    {
                        currentBalance -= 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                Console.WriteLine($"Bought {game}");
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            totalSpent -= currentBalance;
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
