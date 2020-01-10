using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");

            string inputNumbers = Console.ReadLine();

            var validNumbers = regex.Matches(inputNumbers);

            Console.WriteLine(string.Join(", ", validNumbers));
        }
    }
}