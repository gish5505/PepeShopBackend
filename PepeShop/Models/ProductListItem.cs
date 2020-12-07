using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class ProductListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CategoryType Category { get; set; }
    }
}
