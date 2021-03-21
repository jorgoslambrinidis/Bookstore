namespace Bookstore.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Bookstore.Entities;
    using Bookstore.Service.Interfaces;

    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IConvertingService _convertingService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;

        public BookController(
            IBookService bookService,
            IConvertingService convertingService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService
         )
        {
            _bookService = bookService;
            _convertingService = convertingService;
            _authorService = authorService;
            _categoryService = categoryService;
            _publisherService = publisherService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorList = dropdowns.Item2;
            ViewBag.PublisherList = dropdowns.Item3;
            //ViewBag.CategoryList = categories;
            //ViewBag.AuthorList = authors;
            //ViewBag.PublisherList = publishers;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            //if (ModelState.IsValid)
            //{
            _bookService.Add(book);
            //}

            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Edit/2
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookById(id);
            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();
            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorList = dropdowns.Item2;
            ViewBag.PublisherList = dropdowns.Item3;

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            _bookService.Edit(book);
            //_bookService.Edit(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        { 
            // *** option 1
            var book = _bookService.GetBookById(id);
            _bookService.Delete(book.Id);
            // *** option 2
            //_bookService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
