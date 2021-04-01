namespace Bookstore.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Bookstore.Data;
    using Bookstore.Entities;
    using Bookstore.Repository.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            // "INSERT INTO ....VALUES "
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            Book book = GetBookById(bookId);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void EditBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void EditBook(int id)
        {
            var book = GetBookById(id);
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books").AsEnumerable();
            var result = _context.Books.AsEnumerable();
            return result;
        }

        public IEnumerable<Book> GetAllBooksWithFullRelationalData()
        {
            var result = _context.Books
                .Include(a => a.Author)
                .Include(c => c.Category)
                .Include(p => p.Publisher)
                .AsEnumerable();
            return result;
        }

        public Book GetBookById(int id)
        {
            //var result = _context.Books.FromSqlRaw("SELECT * FROM Books WHERE Id = " + id).FirstOrDefault(); ;
            var result = _context.Books.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
