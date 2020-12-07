using Microsoft.EntityFrameworkCore;
using PepeShop.BusinessLogic.Abstractions;
using PepeShop.DAL;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic
{
    public class ProductService : IProductService
    {
        private readonly PepeShopContext _context;

        public ProductService(PepeShopContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task EditProduct(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var result = await _context.Products                
                .FirstOrDefaultAsync(p => p.Id == id);

            return result;
        }

        public async Task<List<ProductListItem>> GetProductList()
        {
            var result = await _context.Products
                .OrderBy(p => p.Id)
                .Select(p => new ProductListItem()
                {
                    Category = p.Category,
                    Code = p.Code,
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                })
                .ToListAsync();

            return result;
        }
    }
}
