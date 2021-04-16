namespace Bookstore.Repository.Interfaces
{
    using Bookstore.Entities;
    using Bookstore.Entities.Quotes;
    using System.Collections.Generic;

    public interface IBookRepository
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void EditBook(int id);
        void DeleteBook(int bookId);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetAllBooksWithFullRelationalData();

        void AddQuote(QuoteMap quote);
    }
}
