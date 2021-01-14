using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }                                      

        public DateTime OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public string OrderStatus { get; set; }

        public DateTime ShipmentDate { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
