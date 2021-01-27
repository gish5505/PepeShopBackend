using Microsoft.AspNetCore.Mvc;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IBasketService _basketService;

        private readonly IOrderService _orderService;

        public OrderController(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService;
            _orderService = orderService;
        }

        [HttpPost("basket/add")]
        public async Task<IActionResult> AddProductToBasket(int productId, int userID, int qty)
        {
            await _basketService.AddProductToBasket(productId, userID, qty);
            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderFromBasket(int userId)
        {
            await _orderService.CreateOrderFromBasket(userId);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery] GetOrdersRequest request)
        {
            var result = await _orderService.GetOrders(request);

            return Ok(result);
        }
    }
}
