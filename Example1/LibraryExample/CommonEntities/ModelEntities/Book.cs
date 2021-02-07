using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public class Book
    {
        public string BookName { get; private set; }
        public int BookId { get; private set; }
        public int ICBN { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public byte Edition { get; private set; }
        public byte BookShelf { get; private set; }
        public byte Row { get; private set; }
        public byte Column { get; private set; }

        private Book() {}

        public static BookBuilder CreateBuilder() => new BookBuilder();


        public class BookBuilder
        {
            internal BookBuilder()
            {
                _book = new Book();
            }

            public Book Build()
            {
                var book = _book;
                _book = null;
                return book;
            }

            private Book _book;
            public BookBuilder SetBookName(string bookName)
            {
                _book.BookName = bookName;
                return this;
            }
            public BookBuilder SetBookId(int bookId)
            {
                _book.BookId = bookId;
                return this;
            }
            public BookBuilder SetICBN(int icbn)
            {
                _book.ICBN = icbn;
                return this;
            }
            public BookBuilder SetAuthor(string author)
            {
                _book.Author = author;
                return this;
            }
            public BookBuilder SetPublisher(string publisher)
            {
                _book.Publisher = publisher;
                return this;
            }
            public BookBuilder SetEdition(byte edition)
            {
                _book.Edition = edition;
                return this;
            }
            public BookBuilder SetBookShelf(byte bookShelf)
            {
                _book.BookShelf = bookShelf;
                return this;
            }
            public BookBuilder SetRow(byte row)
            {
                _book.Row = row;
                return this;
            }
            public BookBuilder SetColumn(byte column)
            {
                _book.Column = column;
                return this;
            }
        }
    }
}
