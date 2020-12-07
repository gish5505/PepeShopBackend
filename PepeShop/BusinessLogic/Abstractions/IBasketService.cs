using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic.Abstractions
{
    public interface IBasketService
    {
        Task AddProductToBasket(Product product, int userId);

        //Task<Basket> GetBasket(int id, int userId);

        //Task RemoveProductFromBasket(Product product, Basket basket);
    }
}
