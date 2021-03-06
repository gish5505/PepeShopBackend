﻿using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic.Abstractions
{
    public interface IOrderService
    {
        Task CreateOrderFromBasket(int userId);

        Task<List<Order>> GetOrders(GetOrdersRequest request);
    }
}
