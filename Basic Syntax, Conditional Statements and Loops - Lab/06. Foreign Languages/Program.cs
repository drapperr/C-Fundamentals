using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string laguage = string.Empty;
            if (country == "England" || country == "USA")
            {
                laguage = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                laguage = "Spanish";
            }
            else
            {
                laguage = "unknown";
            }
            Console.WriteLine(laguage);
        }
    }
}
