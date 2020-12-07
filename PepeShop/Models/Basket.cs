using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class Basket
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public int Id { get; set; }
    }
}
