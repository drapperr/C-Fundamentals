using System;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex separatorRegex = new Regex(@"[\s]*,[\s]+");
            Regex jackpotRegex = new Regex(@"@{20}|#{20}|\${20}|\^{20}");
            Regex winnerTicketRegex = new Regex(@"^[^@#$^]*(@{6,9}|#{6,9}|\${6,9}|\^{6,9})[^@#$^]*(\1)[^@#$^]*$");

            string[] tickets = separatorRegex.Split(Console.ReadLine());

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    if (jackpotRegex.IsMatch(ticket))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                    }
                    else if (winnerTicketRegex.IsMatch(ticket))
                    {
                        string winSymbols = winnerTicketRegex.Match(ticket).Groups[1].Value;
                        int countOfSymbols = winSymbols.Length;
                        char winSymbol = winSymbols[0];
                        Console.WriteLine($"ticket \"{ticket}\" - {countOfSymbols}{winSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}