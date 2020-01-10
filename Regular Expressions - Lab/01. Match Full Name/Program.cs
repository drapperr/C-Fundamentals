using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            var matchedNames = regex.Matches(names);

            foreach (var name in matchedNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}