using System;
using System.Collections.Generic;

namespace Library
{
    public class LibraryManager
    {
        private List<Book> _books = new List<Book>();
        public string Name { get; set; }

        public LibraryManager(string name)
        {
            Name = name;
        }

        public void ListBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine($"{book.Title}, by {book.Author}");
            }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

    }
}