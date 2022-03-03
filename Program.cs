using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams",
                PublishDate = "10-12-1979",
                Genre = "Comic science fiction"
            };

            Book book2 = new Book()
            {
                Title = "Mort",
                Author = "Terry Pratchett",
                PublishDate = "11-12-1987",
                Genre = "Fantasy"
            };

            Book book3 = new Book()
            {
                Title = "Foundation",
                Author = "Isaac Asimov",
                PublishDate = "08-30-1951",
                Genre = "Science fiction"
            };

            Book book4 = new Book()
            {
                Title = "Brave New World",
                Author = "Aldous Huxley",
                PublishDate = "1932",
                Genre = "Dystopian fiction"
            };

            var listOfBooks = new List<Book>() { book1, book2, book3, book4 };

            foreach (Book book in listOfBooks)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
        }
    }
}
