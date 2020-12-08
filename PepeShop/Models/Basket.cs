using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public ICollection<BasketItem> Items { get; set; }
    }
}
