using PepeShop.BusinessLogic.Abstractions;
using PepeShop.DAL;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic
{
    public class OrderService : IBasketService, IOrderService
    {
        private readonly PepeShopContext _context;

        public OrderService(PepeShopContext context)
        {
            _context = context;
        }

        public async Task AddProductToBasket(Product product, int userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            user.Basket.Products.Add(product);

            await _context.SaveChangesAsync();
        }
    }
}
