using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PepeShop.Models
{
    public class UserModel
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public RoleType Role { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Code { get; set; }

        public string Address { get; set; }

        public string Discount { get; set; }

        public List<BasketItem> Basket { get; set; } = new List<BasketItem>();
    }
}
