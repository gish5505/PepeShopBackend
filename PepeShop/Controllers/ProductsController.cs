using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.Models;

namespace PepeShop.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<List<ProductListItem>> GetProducts()
        {
            var result = await _productService.GetProductList();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            var result = await _productService.GetProduct(id);
            return result;
        }       
        
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            await _productService.AddProduct(product);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct([FromBody] Product product)
        {
            await _productService.EditProduct(product);
            return Ok();
        }
    }
}
