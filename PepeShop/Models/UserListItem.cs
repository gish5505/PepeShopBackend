using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class UserListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Address { get; set; }

        public string Discount { get; set; }

        public RoleType Role { get; set; }
    }
}
