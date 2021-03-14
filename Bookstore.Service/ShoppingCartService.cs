using Bookstore.Repository.Interfaces;
using Bookstore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Service
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IBookRepository _bookRepository;

        public ShoppingCartService(
            IShoppingCartRepository shoppingCartRepository,
            IBookRepository bookRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _bookRepository = bookRepository;
        }
    }
}
