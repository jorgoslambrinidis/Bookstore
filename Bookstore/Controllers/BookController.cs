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

        public BookController(IBookService bookService, IConvertingService convertingService)
        {
            _bookService = bookService;
            _convertingService = convertingService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //List<SelectListItem> Categories = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="Romance", Value="1", Selected = true},
            //    new SelectListItem() {Text= "Drama", Value="2"},
            //    new SelectListItem() {Text="Adventure", Value = "3" }
            //};

            //List<SelectListItem> Authors = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="Agatha Christie", Value="1" , Selected = true},
            //    new SelectListItem() {Text= "Stephen King", Value="2"},
            //    new SelectListItem() {Text="William Shakespeare", Value = "3" }
            //};

            //List<SelectListItem> Publishers = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="William Morrow Paperbacks", Value="1", Selected = true},
            //    new SelectListItem() {Text= "Scholastic", Value="2"},
            //    new SelectListItem() {Text="Penguin Random House", Value = "3" }
            //};

            var dropdowns = _bookService.FillDropdowns();
            int stringTest = 1;
            DateTime dateTime = DateTime.Now;

            ViewBag.ConvertedValue = _convertingService.ConvertIntegerToString(stringTest);
            ViewBag.ConvertedValueGenericType = _convertingService.ConvertAnyToString(dateTime);
            ViewBag.CategoryList = dropdowns.Item1;
            ViewBag.AuthorList = dropdowns.Item2;
            ViewBag.PublisherList = dropdowns.Item3;

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
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Romance", Value="1", Selected = true},
                new SelectListItem() {Text= "Drama", Value="2"},
                new SelectListItem() {Text="Adventure", Value = "3" }
            };

            List<SelectListItem> Authors = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Agatha Christie", Value="1" , Selected = true},
                new SelectListItem() {Text= "Stephen King", Value="2"},
                new SelectListItem() {Text="William Shakespeare", Value = "3" }
            };

            List<SelectListItem> Publishers = new List<SelectListItem>()
            {
                new SelectListItem() {Text="William Morrow Paperbacks", Value="1", Selected = true},
                new SelectListItem() {Text= "Scholastic", Value="2"},
                new SelectListItem() {Text="Penguin Random House", Value = "3" }
            };
            int stringTest = 1;
            DateTime dateTime = DateTime.Now;

            ViewBag.ConvertedValue = _convertingService.ConvertIntegerToString(stringTest);
            ViewBag.ConvertedValueGenericType = _convertingService.ConvertAnyToString(dateTime);
            ViewBag.CategoryList = Categories;
            ViewBag.AuthorList = Authors;
            ViewBag.PublisherList = Publishers;

            var book = _bookService.GetBookById(id);
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
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
