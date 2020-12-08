using Microsoft.EntityFrameworkCore;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.DAL;
using PepeShop.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
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

        public async Task AddProductToBasket(int productId, int userId)
        {
            var user = _context.Users
                .Include(x => x.Basket)
                .FirstOrDefault(x => x.Id == userId);

            if (user == null)
            {
                throw new InvalidOperationException();
            }

            var item = new BasketItem()
            {
                ProductId = productId,
            };

            user.Basket.Items.Add(item);

            await _context.SaveChangesAsync();
        }        
    }
}
