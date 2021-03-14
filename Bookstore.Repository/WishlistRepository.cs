using Bookstore.Data;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly DataContext _context;

        public WishlistRepository(DataContext context)
        {
            _context = context;
        }
    }
}
