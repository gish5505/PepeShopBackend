using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Code { get; set; }

        public int Price { get; set; }

        public CategoryType Category { get; set; }

        [JsonIgnore]
        public ICollection<BasketItem> BasketItems { get; set; }

        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
