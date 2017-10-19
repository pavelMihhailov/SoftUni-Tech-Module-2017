using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
{
    class Library
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal PricePerBook { get; set; }
    }
    
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> dictOfLibrary = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Library book = ReadBook();
                if (!dictOfLibrary.ContainsKey(book.Author)) dictOfLibrary.Add(book.Author, 0);
                dictOfLibrary[book.Author] += book.PricePerBook;
            }
            PrintResult(dictOfLibrary);
        }

        private static void PrintResult(Dictionary<string, decimal> dictOfLibrary)
        {
            var result = dictOfLibrary.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var author in result)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        private static Library ReadBook()
        {
            string[] input = Console.ReadLine().Split();
            Library book = new Library();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = input[4];
            book.PricePerBook += decimal.Parse(input[5]);
            return book;
        }
    }
}
