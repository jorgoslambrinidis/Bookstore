namespace Bookstore.Controllers
{
    using Bookstore.Entities;
    using Bookstore.Service.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateAuthorAJAX(Author author)
        {
            _authorService.Add(author);
            return Json(author);
        }
    }
}
