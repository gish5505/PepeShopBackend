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

        public async Task AddProductToBasket(int productId, int userId, int qty)
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
                Quantity = qty,
            };

            user.Basket.Add(item);

            await _context.SaveChangesAsync();
        }

        public async Task CreateOrderFromBasket(int userId)
        {
            var user = await _context.Users
                .Include(b => b.Basket)
                .FirstOrDefaultAsync(b => b.Id == userId);

            if (user == null)
            {

            }

            // создаем новый заказ
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                OrderNumber = "1234567",
                ShipmentDate = DateTime.Now.AddDays(4),
                OrderStatus = "Created"
            };

            // переносим позиции из корзины в заказ

            var orderItems = user.Basket.Select(x => new OrderItem()
            {
                ProductItem = x.Product,
                Quantity = x.Quantity,
                
            })
            .ToList();

            order.OrderItems = orderItems;
            user.Orders.Add(order);

            // сохраняем все

            await _context.SaveChangesAsync();



            // чистим корзину
        }
    }
}
