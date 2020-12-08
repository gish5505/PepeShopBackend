using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class BasketItem
    {
        //public int Id { get; set; }

        [JsonIgnore]
        public Basket Basket { get; set; }

        public int BasketId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }
    }
}
