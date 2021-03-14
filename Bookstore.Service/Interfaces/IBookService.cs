namespace Bookstore.Service.Interfaces
{
    using Bookstore.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;

    public interface IBookService
    {
        void Add(Book book);
        void Edit(Book book);
        void Edit(int id);
        void Delete(int bookId);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();

        Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns();
    }
}
