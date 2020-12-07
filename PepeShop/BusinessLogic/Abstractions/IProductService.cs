using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic.Abstractions
{
    public interface IProductService
    {
        Task<List<ProductListItem>> GetProductList();

        Task<Product> GetProduct(int id);

        Task AddProduct(Product product);

        Task EditProduct(Product product);
    }
}
