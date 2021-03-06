﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [JsonIgnore]
        public Order Order { get; set; }

        public int OrderId { get; set; }

        public Product Product { get; set; }

        [JsonIgnore]
        public int ProductId { get; set; }

        public int Quantity { get; set; }


    }
}
