using System;

namespace _02.AdvertisementMessage
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] autors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var n = int.Parse(Console.ReadLine());

            var phrasesRnd = new Random();
            var eventsRnd = new Random();
            var autorsRnd = new Random();
            var citiesRnd = new Random();

            for (var i = 0; i < n; i++)
                Console.WriteLine(
                    $"{phrases[phrasesRnd.Next(0, phrases.Length)]} {events[eventsRnd.Next(0, events.Length)]} " +
                    $"{autors[autorsRnd.Next(0, autors.Length)]} " +
                    $"- {cities[citiesRnd.Next(0, cities.Length)]}");
        }
    }
}