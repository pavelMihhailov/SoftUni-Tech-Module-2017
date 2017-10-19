using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.BookLibraryModification
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

            Dictionary<string, DateTime> dictOfLibrary = new Dictionary<string, DateTime>();

            Library book = null;
            var listOfBooks = new List<Library>();
            for (int i = 0; i < n; i++)
            {
                book = ReadBook();
                listOfBooks.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            for (int i = 0; i < listOfBooks.Count; i++)
            {
                if (listOfBooks[i].ReleaseDate > givenDate)
                {
                    dictOfLibrary.Add(listOfBooks[i].Title, listOfBooks[i].ReleaseDate);
                }
            }
            PrintResult(dictOfLibrary);
        }

        private static void PrintResult(Dictionary<string, DateTime> dictOfLibrary)
        {
            var result = dictOfLibrary.OrderBy(x => x.Value).ThenBy(x => x.Key);
            foreach (var title in result)
            {
                Console.WriteLine($"{title.Key} -> {title.Value.Day:d2}.{title.Value.Month:d2}.{title.Value.Year}");
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
