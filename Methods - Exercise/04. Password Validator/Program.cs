using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckPassword(password);
        }

        private static void CheckPassword(string password)
        {
            bool validPassword = true;
            bool onlyLettersAndDigit = true;
            int digit = 0;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                validPassword = false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digit++;
                }
                if (!((password[i] >= 48 && password[i] <= 57) ||
                    (password[i] >= 65 && password[i] <= 90) ||
                    (password[i] >= 97 && password[i] <= 122)))
                {
                    onlyLettersAndDigit = false;
                }
            }
            if (!onlyLettersAndDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digit < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                validPassword = false;
            }
            if (validPassword && onlyLettersAndDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
