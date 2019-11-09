using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string> { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"};
            List<string> authors = new List<string> {
                "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Random randomIndex = new Random();
                int phraseIndex = randomIndex.Next(0, phrases.Count);
                int eventIndex = randomIndex.Next(0, events.Count);
                int authorIndex = randomIndex.Next(0, authors.Count);
                int cityIndex = randomIndex.Next(0, cities.Count);

                string text = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} – {cities[cityIndex]}";

                Console.WriteLine(text);
            }
        }
    }
}
