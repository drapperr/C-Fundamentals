using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            List<string> validPasswords = new List<string>();

            foreach (var currentPassword in input)
            {
                bool validLendth = false;
                bool validSybols = true;

                if (currentPassword.Length >= 3 && currentPassword.Length <= 16)
                {
                    validLendth = true;
                }

                foreach (var symbol in currentPassword)
                {
                    if (!(char.IsLetterOrDigit(symbol)
                          || symbol == '-' || symbol == '_'))
                    {
                        validSybols = false;
                        break;
                    }
                }
                if (validSybols && validLendth)
                {
                    validPasswords.Add(currentPassword);
                }
            }
            foreach (var password in validPasswords)
            {
                Console.WriteLine(password);
            }
        }
    }
}