namespace Bookstore.Controllers
{
    using Bookstore.Entities.Quotes;
    using Bookstore.Models;
    using Bookstore.Service.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using System.Diagnostics;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;

        public HomeController(
            ILogger<HomeController> logger,
            IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            var booksWithFullData = _bookService.GetAllBooksWithFullRelationalData();
            
            var homeViewModel = new HomeViewModel()
            {
                AllBooksList = books
            };
            return View(homeViewModel); //PartialView(); 
        }

        public async Task<JsonResult> GetQuotes()
        {
            QuotesData quotesData = new QuotesData();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://opinionated-quotes-api.gigalixirapp.com/v1/quotes"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    quotesData = JsonConvert.DeserializeObject<QuotesData>(apiResponse);
                    
                    //foreach (var quote in quotesData.Quotes)
                    //{
                    //    QuoteMap newQuote = new QuoteMap()
                    //    {
                    //        Author = quote.Author,
                    //        Lang = quote.Lang,
                    //        Quote = quote.quote,
                    //        Tags = string.Join(",", quote.Tags.ToArray())
                    //    };

                    //    _bookService.AddQuote(newQuote);
                    //}
                }
            }

            return Json(quotesData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Helper Methods

        #endregion
    }
}
